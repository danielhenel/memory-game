using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form1 : Form
    {
        int[,] state;
        int points = 0;
        int animationSpeed = 1000;
        int clickedCardsCounter = 0;
        int[,] clickedCards = new int[2, 2] { {-1, -1 }, { -1, -1 } };
        TableLayoutPanel tab = new TableLayoutPanel();

        public Form1()
        {
            InitializeComponent();
        }

        private void easyButtonClick(object sender, EventArgs e)
        {
            Form2 game = new Form2();
            TableLayoutPanel tab = new TableLayoutPanel();
            tab.RowCount = 6;
            tab.ColumnCount = 8;
            
            game.ShowDialog();
        }

        private void mediumButtonClick(object sender, EventArgs e)
        {
            Form2 game = new Form2();
        }



        private void hardButtonClick(object sender, EventArgs e)
        {
            Form2 game = new Form2();
            TableLayoutPanel tab = new TableLayoutPanel();
            tab.RowCount = 10;
            tab.ColumnCount = 12;
            game.Controls.Add(new Button());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


    }
}
