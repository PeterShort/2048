using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2048.Src;

namespace _2048 {
    public partial class Form1 : Form {

        private Board board;

        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
             board = new Board(4, 4, gameControlFrame);
            board.PlaceTwoNumbersRandomly();
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
