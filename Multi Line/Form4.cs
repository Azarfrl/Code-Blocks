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
    public partial class Form4 : Form
    {
        PictureBox[] pictures = new PictureBox[4];
        List<string> blocks = new List<string>();
        Form2 previousForm;

        public Form4(Form2 form2)
        {
            InitializeComponent();
            previousForm = form2;

            txtPrintInput.Visible = false;

            for (int i = 0; i < 4; i++)
            {
                pictures[i] = new PictureBox();
                pictures[i].SizeMode = PictureBoxSizeMode.StretchImage;
                pictures[i].AllowDrop = true;
                pictures[i].DragEnter += new DragEventHandler(pictures_DragEnter);
                pictures[i].DragDrop += new DragEventHandler(pictures_DragDrop);
                tblCodeArea.Controls.Add(pictures[i]);
            }
        }

        private void codeBlock_MouseDown(object sender, MouseEventArgs e)
        {
            PictureBox codeBlock = sender as PictureBox;
            DataObject dragImage = new DataObject();
            dragImage.SetData(DataFormats.Bitmap, true, codeBlock.Image);
            dragImage.SetData(DataFormats.Text, true, codeBlock.Tag);
            DoDragDrop(dragImage, DragDropEffects.Copy);
        }

        private void pictures_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }

        private void pictures_DragDrop(object sender, DragEventArgs e)
        {
            PictureBox picture = sender as PictureBox;
            picture.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
            picture.Tag = e.Data.GetData(TextDataFormat.Text.ToString());

            lblList.Text = "";
            blocks.Clear();

            bool hasPrintBlock = false;

            for (int i = 0; i < 4; i++)
            {
                string tag = pictures[i].Tag?.ToString() ?? "";
                blocks.Add(tag);

                if (tag.Contains("When clicked"))
                {
                    lblList.Text += "Handle a Click Event here\n";
                }
                else if (tag.Contains("Print"))
                {
                    lblInput.Text = "Input:";
                    lblList.Text += "Print command here\n";
                    hasPrintBlock = true;
                }
            }

            txtPrintInput.Visible = hasPrintBlock;
            if (!hasPrintBlock) txtPrintInput.Text = "";
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            lblTutorial.Text = "";
            label1.Text = "";
            label2.Text = "";
            btnRun.Visible = false;
            tblCodeArea.Visible = false;
            pbPrint.Visible = false;
            pbWhenClicked.Visible = false;
            btnClear.Visible = false;
            txtPrintInput.Visible = false;
            btnComplete.Enabled = false;
            btnNextStep.Text = "Start";
        }

        private int tutorialStep = 0;
        private readonly string[] tutorialTexts = new string[]
        {
            "Step 1: Welcome to Level 1! We will be using blocks to learn how to print. You can see the blocks below. Try dragging and dropping the when click block at the top and the print block under it! Once done click next!",
            "Step 2: Now that you have the two blocks in the table, you can see a textbox appear, this is so that we can type anything we want. Type anything you want to print! Once done click next!",
            "Step 3: Now press the run button at the bottom to run the blocks! Whatever you have written should be printed out! Now you have finished and ready to go to level 2!"
        };

        private void button1_Click(object sender, EventArgs e)
        {
            LevelProgress.Lock1 = false;
            LevelProgress.Level1Completed = true;
            MessageBox.Show("Level 1 Completed!");
            previousForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private void btnNextStep_Click(object sender, EventArgs e)
        {
            lblTutorial.Text = tutorialTexts[tutorialStep];
            tutorialStep++;

            if (tutorialStep == 1)
                btnNextStep.Text = "Next";
                label1.Text = "List of blocks:";
                label2.Text = "Available blocks:";
                btnRun.Visible = true;
                tblCodeArea.Visible = true;
                pbPrint.Visible = true;
                pbWhenClicked.Visible = true;
                btnClear.Visible = true;

            if (tutorialStep == 2)
                btnPreviousStep.Visible = true;

            if (tutorialStep >= tutorialTexts.Length)
            {
                btnNextStep.Enabled = false;
                btnComplete.Enabled = true;
            }
        }

        private void btnPreviousStep_Click(object sender, EventArgs e)
        {
            if (tutorialStep > 1)
            {
                tutorialStep--;
                lblTutorial.Text = tutorialTexts[tutorialStep - 1];
                btnNextStep.Enabled = true;
                btnComplete.Enabled = false;
            }

            if (tutorialStep == 1)
                btnPreviousStep.Visible = false;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            foreach (Control ctrl in tblCodeArea.Controls)
            {
                if (ctrl is PictureBox pic)
                {
                    pic.Image = null;
                    pic.Tag = null;
                }
            }

            blocks.Clear();
            lblList.Text = "";
            txtPrintInput.Visible = false;
            txtPrintInput.Text = "";
            lblOutput.Text = "";
        }

        private void btnRun_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            blocks.Clear();

            for (int i = 0; i < 4; i++)
            {
                blocks.Add(pictures[i].Tag?.ToString() ?? "");
            }

            for (int i = 0; i < blocks.Count - 1; i++)
            {
                if (blocks[i].Contains("When") && blocks[i + 1].Contains("Print"))
                {
                    lblOutput.Text = txtPrintInput.Text;
                    return;
                }
            }

            lblOutput.Text = "No valid block combination found.";
        }

        private void pbPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
