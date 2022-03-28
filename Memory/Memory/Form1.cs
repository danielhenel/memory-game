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
        public Form1()
        {
            InitializeComponent();
        }

        private void easyButtonClick(object sender, EventArgs e)
        {
            Form2 game = new Form2(6,8,100);
        }

        private void mediumButtonClick(object sender, EventArgs e)
        {
            Form2 game = new Form2(8,10,75);
        }

        private void hardButtonClick(object sender, EventArgs e)
        {
            Form2 game = new Form2(10,12,50);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }


    }
}
