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
            game.Width = 1075;
            game.Height = 1000;
            TableLayoutPanel tab = new TableLayoutPanel();
            tab.RowCount = 8;
            tab.ColumnCount = 10;
            tab.Width = 1075;
            tab.Height = 850;

            //crating random state
            createRandomState(ref state, tab.RowCount, tab.ColumnCount);

            //creating buttons
            createButtons(tab,tab.RowCount,tab.ColumnCount);

            game.Controls.Add(tab);
            game.ShowDialog();
        }

        protected void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string path = Environment.CurrentDirectory;
            button.Image = Image.FromFile(path+"\\images\\image (5).png");
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

        private void createButtons(TableLayoutPanel tab, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                {
                    Button button = new Button();
                    button.Width = 100;
                    button.Height = 100;
                    button.Click += new EventHandler(button_Click);
                    string path = Environment.CurrentDirectory;
                   // button.Image = Image.FromFile(path + "\\images\\sky.jpg");
                    button.Image = Image.FromFile(path + "\\images\\image ("+ state[i,j].ToString() +").png");
                    tab.Controls.Add(button, i, j);
                }
        }

        private void createRandomState(ref int[,] array, int rows, int cols)
        {
            array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    array[i,j] = i * cols + j + 1 - j%2;

            //Knuth shuffle
            Random random = new Random();
            while (rows>0)
            {
                rows--;
                int x = cols;
                cols--;
                while (cols > 0)
                {
                    int i = random.Next(rows + 1);
                    int j = random.Next(cols + 1);

                    int temp = array[i, j];
                    array[i, j] = array[rows, cols];
                    array[rows, cols] = temp;
                    cols--;
                }
                cols = x;
            }
        }

        private bool checkPair(int i1, int j1, int i2, int j2)
        {
            return state[i1, j1] == state[i2, j2];
        }

        private void addPoints()
        {
            points += 5;
        }
    }
}
