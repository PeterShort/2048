using System;
using System.Drawing;
using System.Windows.Forms;

namespace _2048.Src {

    public class Board {
        private Cell[,] board;

        private Button[,] slots;

        private int width;
        private int height;

        public Board(int width, int height, FlowLayoutPanel panel) {
            this.width = width;
            this.height = height;

            board = new Cell[width, height];
            slots = new Button[width, height];

            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    board[x, y] = new Cell(-1, Color.White);
                }
            }

            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    Button button = new Button {
                        BackColor = board[x, y].CellColour,
                        Text = "",
                        Size = new Size(72, 72),
                        Enabled = false
                    };
                    panel.Controls.Add(button);
                    slots[x, y] = button;
                }
            }
        }

        public int ReturnCellValue(int x, int y) {
            return board[x, y].Number;
        }

        public bool IsBoardFull() {
            int count = 0;
            foreach (Cell cell in board) {
                if (cell.Number != -1)
                    count++;
            }

            if (count >= board.Length) {
                return true;
            } else {
                return false;
            }
        }

        public void UpdateBoardUi() {
            for (int x = 0; x < width; x++) {
                for (int y = 0; y < height; y++) {
                    if (board[x, y].Number != -1) {
                        slots[x, y].Text = board[x, y].Number.ToString();
                        slots[x, y].BackColor = board[x, y].CellColour;
                    }
                }
            }
        }

        public void PlaceTwoNumbersRandomly() {
            Random rnd = new Random();
            for (int i = 0; i < 2; i++) {
                int num = 0;
                int[] nums = { 2, 4 };

               
                int row = rnd.Next(board.GetLength(0));
                int column = rnd.Next(board.GetLength(1));

                Cell c = board[row, column];

                num = nums[rnd.Next(nums.Length)];

                c.Number = num;
                UpdateBoardUi();
            }

         
     
        }

        public void UpMove() {
        }

        public void DownMove() {
        }

        public void LeftMove() {
        }

        public void RightMove() {
        }
    }

    public class Cell {
        public int Number { get; set; }
        public Color CellColour { get; set; }

        public Cell(int Number, Color CellColour) {
            this.Number = Number;
            this.CellColour = CellColour;
        }
    }
}