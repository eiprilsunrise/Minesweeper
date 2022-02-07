namespace Minesweeper
{
    public partial class Setup : Form
    {
        public Setup()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            //Показать главную форму с игрой (передача 3х параметров)
            new Main(MinesTrack.Value, SizeXTrack.Value, SizeYTrack.Value).Show(this);
            //Скрыть форму настроек
            Hide();
        }

        //Отобразить значение трекбаров
        private void MinesTrack_Scroll(object sender, EventArgs e)
        {
            MineLbl.Text = MinesTrack.Value.ToString();
        }

        private void SizeXTrack_Scroll(object sender, EventArgs e)
        {
            SizeXLbl.Text = SizeXTrack.Value.ToString();
        }

        private void SizeYTrack_Scroll(object sender, EventArgs e)
        {
            SizeYLbl.Text = SizeYTrack.Value.ToString();
        }
    }
}
