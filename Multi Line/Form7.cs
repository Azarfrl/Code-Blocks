using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Multi_Line
{
    public partial class Form7 : Form
    {
        Form2 previousForm;
        public Form7(Form2 form2)
        {
            InitializeComponent();
            previousForm = form2;
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Incorrect! Try again.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Great guess but no!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            LevelProgress.Lock4 = false;
            LevelProgress.Level4Completed = true;
            MessageBox.Show("Correct! The Print block shows text.");
            previousForm.Show();
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nope! That’s not what the print Block does.");
        }
    }
}
