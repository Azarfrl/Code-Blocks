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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = LevelProgress.Level1Completed;
            button4.Enabled = LevelProgress.Level2Completed;
            button5.Enabled = LevelProgress.Level3Completed;
            button6.Enabled = LevelProgress.Level4Completed;
            button7.Enabled = LevelProgress.Level5Completed;

            lock1.Visible = LevelProgress.Lock1;
            lock2.Visible = LevelProgress.Lock2;
            lock3.Visible = LevelProgress.Lock3;
            lock4.Visible = LevelProgress.Lock4;
            lock5.Visible = LevelProgress.Lock5;

        }

        protected override void OnActivated(EventArgs e)
        {
            base.OnActivated(e);
            button3.Enabled = LevelProgress.Level1Completed;
            button4.Enabled = LevelProgress.Level2Completed;
            button5.Enabled = LevelProgress.Level3Completed;
            button6.Enabled = LevelProgress.Level4Completed;
            button7.Enabled = LevelProgress.Level5Completed;

            lock1.Visible = LevelProgress.Lock1;
            lock2.Visible = LevelProgress.Lock2;
            lock3.Visible = LevelProgress.Lock3;
            lock4.Visible = LevelProgress.Lock4;
            lock5.Visible = LevelProgress.Lock5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4(this);
            form4.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5 form5 = new Form5(this);
            form5.Show();
            this.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form6 form6 = new Form6(this);
            form6.Show();
            this.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7(this);
            form7.Show();
            this.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form8 form8 = new Form8(this);
            form8.Show();
            this.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form9 form9 = new Form9(this);
            form9.Show();
            this.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
