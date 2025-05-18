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
    public partial class Form9 : Form
    {
        Form2 previousForm;
        public Form9(Form2 form2)
        {
            InitializeComponent();
            previousForm = form2;
        }


        private void Form9_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            LevelProgress.Level6Completed = true;
            MessageBox.Show("Correct! The quiz levels has been finished!");
            Form10 f10 = new Form10();
            f10.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Great guess but no!");

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Great guess but no!");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nope! That’s not what the wait block does.");

        }
    }
}
