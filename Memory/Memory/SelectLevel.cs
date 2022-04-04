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
    public partial class SelectLevel : Form
    {
        public SelectLevel()
        {
            InitializeComponent();
        }

        private void easyButtonClick(object sender, EventArgs e)
        {
            Settings.setCardsSizeValue("LARGE");
            Game game = new Game(6,8,Settings.getCardsSize()); //default cards size
        }

        private void mediumButtonClick(object sender, EventArgs e)
        {
            Settings.setCardsSizeValue("MEDIUM");
            Game game = new Game(8,10, Settings.getCardsSize()); //default cards size
        }

        private void hardButtonClick(object sender, EventArgs e)
        {
            Settings.setCardsSizeValue("SMALL");
            Game game = new Game(10,12, Settings.getCardsSize()); //default cards size
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void SelectLevel_Load(object sender, EventArgs e)
        {

        }
    }
}
