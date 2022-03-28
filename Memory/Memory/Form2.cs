using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memory
{
    public partial class Form2 : Form
    {
        int[,] state;
        int points = 0;
        int animationSpeed = 1000;
        int clickedCardsCounter = 0;
        int[,] clickedCards = new int[2, 2] { { -1, -1 }, { -1, -1 } };
        TableLayoutPanel tab = new TableLayoutPanel();
        public Form2()
        {
            InitializeComponent();

            this.Width = 1075;
            this.Height = 1000;
            tab.RowCount = 8;
            tab.ColumnCount = 10;
            tab.Width = 1075;
            tab.Height = 850;

            //crating random state
            createRandomState(ref state, tab.RowCount, tab.ColumnCount);

            //creating buttons
            createButtons(tab, tab.RowCount, tab.ColumnCount);

            this.Controls.Add(tab);
            this.ShowDialog();
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
                    button.Image = Image.FromFile(path + "\\images\\sky.jpg");
                    tab.Controls.Add(button, i, j);
                }
        }

        private void createRandomState(ref int[,] array, int rows, int cols)
        {
            array = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    array[i, j] = i * cols + j + 1 - j % 2;

            //Knuth shuffle
            Random random = new Random();
            while (rows > 0)
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
            return state[i1, j1] == state[i2, j2] & i1 != i2 & j1 != j2;
        }

        private void addPoints()
        {
            points += 5;
        }

        protected async void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string path = Environment.CurrentDirectory;
            int i = tab.GetRow((Control)sender);
            int j = tab.GetColumn((Control)sender);

            button.Image = Image.FromFile(path + "\\images\\image (" + state[i, j].ToString() + ").png");
            await Task.Delay(animationSpeed);
            clickedCardsCounter++;
            if (clickedCardsCounter == 1)
            {
                clickedCards[0, 0] = i;
                clickedCards[0, 1] = j;
            }
            else if (clickedCardsCounter == 2)
            {
                clickedCards[1, 0] = i;
                clickedCards[1, 1] = j;

                if (checkPair(clickedCards[0, 0], clickedCards[0, 1], clickedCards[1, 0], clickedCards[1, 1]))
                {
                    addPoints();
                    tab.Controls.Remove(tab.GetControlFromPosition(clickedCards[0, 1], clickedCards[0, 0]));
                    tab.Controls.Remove(tab.GetControlFromPosition(clickedCards[1, 1], clickedCards[1, 0]));
                }
                else
                {

                    ((Button)tab.GetControlFromPosition(clickedCards[0, 1], clickedCards[0, 0])).Image =
                        Image.FromFile(path + "\\images\\sky.jpg");

                    ((Button)tab.GetControlFromPosition(clickedCards[1, 1], clickedCards[1, 0])).Image =
                         Image.FromFile(path + "\\images\\sky.jpg");

                }

                clickedCardsCounter = 0;
                clickedCards[0, 0] = -1;
                clickedCards[0, 1] = -1;
                clickedCards[1, 0] = -1;
                clickedCards[1, 1] = -1;
            }
        }
    }
}
