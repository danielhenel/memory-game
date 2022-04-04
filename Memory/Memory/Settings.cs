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
    public partial class Settings : Form
    {
        Form parent;
        static String languageValue;
        static int animationSpeedValue;
        static int presentationTimeValue;
        static String cardsSizeValue;
        static String soundValue;

        public Settings(Form parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void animationSpeed_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void cardSizeLabel_Click(object sender, EventArgs e)
        {

        }

        private void presentationTimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            parent.Location = this.Location;
            parent.Show();
            this.Hide();
            
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            parent.Show();
            this.Hide();
            
        }

        private void animationUp_Click(object sender, EventArgs e)
        {
           
           int actuallValue = Int32.Parse(this.animationSpeedBox.Text);
           if (actuallValue < 10) // max value 10 seconds
            {
                actuallValue++;
                this.animationSpeedBox.Text = actuallValue.ToString();
            }
        }

        private void animationDown_Click(object sender, EventArgs e)
        {
            int actuallValue = Int32.Parse(this.animationSpeedBox.Text);
            if (actuallValue > 1) // max value 1 second
            {
                actuallValue--;
                this.animationSpeedBox.Text = actuallValue.ToString();
            }
        }

        private void presentationDown_Click(object sender, EventArgs e)
        {
            int actuallValue = Int32.Parse(this.presentationTimeBox.Text);
            if (actuallValue >= 5) // min value 0 seconds
            {
                actuallValue -= 5;
                this.presentationTimeBox.Text = actuallValue.ToString();
            }
        }

        private void presentationUp_Click(object sender, EventArgs e)
        {
            int actuallValue = Int32.Parse(this.presentationTimeBox.Text);
            if (actuallValue < 120) // max value 120 seconds
            {
                actuallValue += 5;
                this.presentationTimeBox.Text = actuallValue.ToString();
            }
        }
    }
}
