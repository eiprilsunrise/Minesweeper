using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Minesweeper
{
    //класс Cell наследуется от класса Button и наследует все его свойства
    internal class Cell : Button
    {
        public bool IsMine { get; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsFlagged { get; set; } = false;
        public bool Opened { get; set; } = false;

        //событие на окончание игры, где true это победа, а false поражение
        public static Action<bool> OnEnd = default!;

        //Массив для хранения ссылок на соседние клетки
        public Cell[] AdjCells { get; private set; } = default!;
        //Статический лист для хранения всех клеток
        private static List<Cell> cells { get; } = new List<Cell>();

        public Cell(bool isMine, int x, int y)
        {
            IsMine = isMine;
            X = x;
            Y = y;

            //регистрация события на клик по клетке
            MouseDown += HandleClick;
            //придание внешнего вида клетке
            FlatStyle = FlatStyle.Flat;
            ForeColor = Color.Black;
            this.Font = new Font("Cascadia Code", 14, FontStyle.Bold);
            //добавление клетки в статический лист
            cells.Add(this);
        }

        private void HandleClick(object? sender, MouseEventArgs e)
        {
            //игнорировать, если клетка уже открыта
            if (Opened)
            {
                return;
            }
            //флажок на правую кнопку мыши
            if (e.Button == MouseButtons.Right)
            {
                IsFlagged = !IsFlagged;
                Text = IsFlagged ? "F" : "";
                ForeColor = IsFlagged ? Color.Orange : Color.Black;
                return;
            }
            //если клетка является миной, открыть все мины и закончить игру
            if (IsMine)
            {
                cells.Where(cell => cell.IsMine).ToList().ForEach(cell =>
                {
                    cell.BackColor = Color.Red;
                });
                OnEnd(false);
                return;
            }
            //открыть клетку
            OpenCell();
        }

        private void OpenCell()
        {
            if (Opened)
            {
                return;
            }

            Opened = true;
            BackColor = Color.Black;
            ForeColor = Color.White;
            //получить количество клеток рядом
            var count = GetMinesCount();
            Text = count == 0 ? "" : count.ToString();
            //проверка, если все клетки без мин открыты, вызвать событие на победу
            if (cells.Where(cell => !cell.IsMine).All(cell => cell.Opened))
            {
                OnEnd(true);
                return;
            }
            if (count == 0)
            {
                //открыть все соседние нулевые клеткиы
                OpenCellIfNoMines();
            }

        }

        private void OpenCellIfNoMines()
        {
            OpenCell();
            //вызвать открытие соседних клеток, если у клетки 0 или 1 соседних мин
            AdjCells
                .Where(c => !c.IsMine && !c.Opened && c.GetMinesCount() <= 1)
                .ToList()
                .ForEach(cell => cell.OpenCellIfNoMines());

        }

        private int GetMinesCount()
        {
            //получить количество соседних клеток с минами
            return AdjCells.Count(c => c.IsMine);
        }

        private static Cell[] GetAdjCells(Cell cell)
        {
            //получить все соседние клетки у cell
            return cells.Where(c => (
            (c.X - 1 == cell.X && c.Y == cell.Y) ||
            (c.X + 1 == cell.X && c.Y == cell.Y) ||
            (c.X == cell.X && c.Y - 1 == cell.Y) ||
            (c.X == cell.X && c.Y + 1 == cell.Y) ||
            (c.X - 1 == cell.X && c.Y - 1 == cell.Y) ||
            (c.X + 1 == cell.X && c.Y + 1 == cell.Y) ||
            (c.X - 1 == cell.X && c.Y + 1 == cell.Y) ||
            (c.X + 1 == cell.X && c.Y - 1 == cell.Y))).ToArray();
        }

        public static void Init()
        {
            //найти все соседние клетки у всех клеток
            cells.ForEach(cell =>
            {
                cell.AdjCells = GetAdjCells(cell);
            });
        }
        public static void Reset()
        {
            //обнулить событие, очистить статический лист
            OnEnd = default!;
            cells.Clear();
        }
    }
}
