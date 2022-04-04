using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Memory
{
    public partial class Game : Form
    {
        int[,] state;
        int points = 0;
        private string path = Environment.CurrentDirectory;
        int animationSpeed = 1000;
        TableLayoutPanel cardsTable;
        int clickedCardsCounter = 0;
        int[,] clickedCards = new int[2, 2] { { -1, -1 }, { -1, -1 } };
        int numberOfRows;
        int numberOfColumns;
        int cardSize;
        DateTime launchDate;
        int ticks = 0;
        private Boolean presentationMode = true;
        public Game(int rows, int cols, int cardSize)
        {
            InitializeComponent();

            numberOfRows = rows;
            numberOfColumns = cols;

            createTable();

            createRandomState();

            //creating buttons
            createButtons();
            //presentation time

            launchDate = DateTime.Now;
            this.timeLabel.Text = Settings.getPresentationTimeValue().ToString();   
            this.gameTimer.Start();
            this.ShowDialog();
        }

        private void createTable()
        {
            cardsTable = new TableLayoutPanel();
            this.cardsTable.RowCount = numberOfRows;
            this.cardsTable.ColumnCount = numberOfColumns;

            for (int i = 0; i < numberOfColumns; i++)
                this.cardsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100/numberOfColumns));
            for (int i = 0; i < numberOfRows; i++)
                this.cardsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100/numberOfRows));

            this.cardsTable.Width = this.panelForCards.Width - 100;
            this.cardsTable.Height = this.panelForCards.Height - 50;
            panelForCards.Controls.Add(cardsTable);
            this.cardsTable.Location = new Point(this.cardsTable.Parent.Width / 2 - this.cardsTable.Width / 2, this.cardsTable.Parent.Height / 2 - this.cardsTable.Height / 2);
            int shorterEdge;
            if (this.cardsTable.Width < this.cardsTable.Height)
                shorterEdge = this.cardsTable.Width / this.cardsTable.ColumnCount;
            else shorterEdge = this.cardsTable.Height / this.cardsTable.RowCount;
            cardSize = shorterEdge;
        }

        private void createButtons()
        {

            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    Button button = new Button();
                    button.Width = cardSize;
                    button.Height = cardSize;
                    button.Click += new EventHandler(button_Click);
                    button.Image = Image.FromFile(path + "\\images\\image (" + state[i, j].ToString() + ").png");
                    this.cardsTable.Controls.Add(button, j, i);
                }
            }
        }

        private void hideCards()
        {
            for (int i = 0; i < numberOfRows; i++)
            {
                for (int j = 0; j < numberOfColumns; j++)
                {
                    ((Button)cardsTable.GetControlFromPosition(j, i)).Image = Image.FromFile(path + "\\images\\sky.jpg");
                }
            }
        }

        private void createRandomState()
        {
            int rows = numberOfRows;
            int cols = numberOfColumns;
            state = new int[rows, cols];
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < cols; j++)
                    state[i, j] = i * cols + j + 1 - j % 2;

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
                    int temp = state[i, j];
                    state[i, j] = state[rows, cols];
                    state[rows, cols] = temp;
                    cols--;
                }
                cols = x;
            }
        }

        private bool checkPair(int i1, int j1, int i2, int j2)
        {
            return state[i1, j1] == state[i2, j2] & (i1 != i2 || j1 != j2);
        }

        private void addPoints()
        {
            points += 5;
        }

        protected async void button_Click(object sender, EventArgs e)
        {
            Button button = sender as Button;
            string path = Environment.CurrentDirectory;
            int i = cardsTable.GetRow((Control)sender);
            int j = cardsTable.GetColumn((Control)sender);

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
                    cardsTable.GetControlFromPosition(clickedCards[0, 1], clickedCards[0, 0]).Visible = false;
                    cardsTable.GetControlFromPosition(clickedCards[1, 1], clickedCards[1, 0]).Visible = false;
                }
                else
                {

                    ((Button)cardsTable.GetControlFromPosition(clickedCards[0, 1], clickedCards[0, 0])).Image =
                        Image.FromFile(path + "\\images\\sky.jpg");

                    ((Button)cardsTable.GetControlFromPosition(clickedCards[1, 1], clickedCards[1, 0])).Image =
                         Image.FromFile(path + "\\images\\sky.jpg");

                }

                clickedCardsCounter = 0;
                clickedCards[0, 0] = -1;
                clickedCards[0, 1] = -1;
                clickedCards[1, 0] = -1;
                clickedCards[1, 1] = -1;
            }
        }

        private void Game_Load(object sender, EventArgs e)
        {

        }

        private void panelForCards_Resize(object sender, EventArgs e)
        {
            resize();
        }

        private void resize()
        {
            Thread.Sleep(10);
            this.cardsTable.Width = this.panelForCards.Width - 100;
            this.cardsTable.Height = this.panelForCards.Height - 50;
            this.cardsTable.Location = new Point(this.cardsTable.Parent.Width / 2 - this.cardsTable.Width / 2, this.cardsTable.Parent.Height / 2 - this.cardsTable.Height / 2);


            //cards resizing
            int shorterEdge;
            if (this.cardsTable.Width < this.cardsTable.Height)
                shorterEdge = this.cardsTable.Width / this.cardsTable.ColumnCount;
            else shorterEdge = this.cardsTable.Height / this.cardsTable.RowCount;
            cardSize = shorterEdge;

            this.cardsTable.Visible = false;
            for(int i = 0; i < this.cardsTable.ColumnCount; i++)
                for(int j = 0; j < this.cardsTable.RowCount; j++)
                {
                    ((Button)cardsTable.GetControlFromPosition(i, j)).Width = cardSize;
                    ((Button)cardsTable.GetControlFromPosition(i, j)).Height = cardSize;
                }
            this.cardsTable.Visible = true;
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            Settings settingsForm = new Settings(this);
            settingsForm.StartPosition = FormStartPosition.Manual;
            settingsForm.Location = this.Location;
            settingsForm.Show();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            ticks++;
            if (presentationMode) presentation();
            else showGameTime();
        }

        private void presentation()
        {
            if(Settings.getPresentationTimeValue() - ticks > 0)
            this.timeLabel.Text = (Settings.getPresentationTimeValue() - ticks).ToString();
            else
            {
                this.timeLabel.Text = "0";
                presentationMode = false;
                hideCards();
                ticks = 0;
            }
        }

        private void showGameTime()
        {
            this.timeLabel.Text = ticks.ToString();
        }

        private void panelForCards_Paint(object sender, PaintEventArgs e)
        {

        }
    }

}
