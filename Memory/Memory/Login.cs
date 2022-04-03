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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void nextButtonClick(object sender, EventArgs e)
        {
            this.Hide();
            SelectLevel selectlevel = new SelectLevel();
            selectlevel.StartPosition = FormStartPosition.Manual;
            selectlevel.Location = this.Location;
            selectlevel.Show();
        }

        private void settingsButtonClick(object sender, EventArgs e)
        {

        }

        private void title_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
