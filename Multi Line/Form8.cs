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
    public partial class Form8 : Form
    {
        Form2 previousForm;
        public Form8(Form2 form2)
        {
            InitializeComponent();
            previousForm = form2;
        }


        private void Form8_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Great guess but no!");

        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Great guess but no!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nope! That’s not what the for loop block does.");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            LevelProgress.Lock5 = false;
            LevelProgress.Level5Completed = true;
            MessageBox.Show("Correct! The Print Block shows text.");
            previousForm.Show();
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
