namespace Minesweeper
{
    public partial class Main : Form
    {
        public const int CellSize = 32;

        public int MinePercent { get; } = 10;
        public int CellsX { get; } = 20;
        public int CellsY { get; } = 15;

        public Main(int percent, int cellsX, int cellsY)
        {
            MinePercent = percent;
            CellsX = cellsX;
            CellsY = cellsY;
            //Action событие на конец игры (вызывается в классе Cell)
            Cell.OnEnd += (isWin) => {
                MessageBox.Show(isWin ? "You win!" : "You lose!");
                Close();
            };
            //Двойная буферизация для лучшей производительности
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            //Подстроить размер формы под количество клеток
            Size = new Size(20 + CellsX * (CellSize + 5), 5 + (CellsY + 1) * (CellSize + 5));
            //Центрировать форму
            CenterToScreen();
            //Создать клетки
            SpawnCells(CellsX, CellsY);
        }

        private void SpawnCells(int x, int y)
        {
            //Двойной цикл для создания клеток по горизонтали i и вертикали j
            for (int i = 0; i < CellsX; i++)
            {
                for (int j = 0; j < CellsY; j++)
                {
                    //создание клетки со случайным значением мины (зависит от процентов)
                    var cell = new Cell(GetMineRandom(MinePercent), i, j);
                    //размер клетки
                    cell.Size = new Size(CellSize, CellSize);
                    //положение клетки
                    cell.Location = new Point(5 + i * (CellSize + 5), 5 + j * (CellSize + 5));
                    //добавить на форму
                    Controls.Add(cell);
                }
            }
            //Инициализировать класс Cell после создания клеток
            Cell.Init();
        }

        private static bool GetMineRandom(int percent)
        {
            var random = new Random();
            //случайным образом выдать true или false в зависимости от процента
            return random.Next(100) < percent;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            //сбросить класс Cell и отобразить форму настроек
            Cell.Reset();
            Owner.Show();
        }
    }
}