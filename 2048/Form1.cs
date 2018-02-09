using _2048.Src;
using System;
using System.Windows.Forms;

namespace _2048 {

    public partial class Form1 : Form {
        private Board board;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            board = new Board(4, 4, gameControlFrame);
            board.PlaceNumbersRandomly(2);
        }

        private void ButtonUp_Click(object sender, EventArgs e) {
            board.UpMove();
        }

        private void ButtonRight_Click(object sender, EventArgs e) {
            board.RightMove();
        }

        private void ButtonDown_Click(object sender, EventArgs e) {
            board.DownMove();
        }

        private void ButtonLeft_Click(object sender, EventArgs e) {
            board.LeftMove();
        }
    }
}