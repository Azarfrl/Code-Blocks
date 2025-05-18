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
    public partial class Form6 : Form
    {
        PictureBox[] pictures = new PictureBox[4];
        List<string> blocks = new List<string>();
        Form2 previousForm;
        public Form6(Form2 form2)
        {
            InitializeComponent();
            previousForm = form2;

            txtPrintInput.Visible = false;
            txtLoopCount.Visible = false;
            txtWaitSeconds.Visible = false;

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

        private void Form6_Load(object sender, EventArgs e)
        {
            lblTutorial.Text = "";
            label1.Text = "";
            label2.Text = "";
            lblCountText.Text = "";
            lblWaitText.Text = "";
            btnRun.Visible = false;
            tblCodeArea.Visible = false;
            pbPrint.Visible = false;
            pbWhenClicked.Visible = false;
            pbForLoop.Visible = false;
            pbWait.Visible = false;
            btnClear.Visible = false;
            txtPrintInput.Visible = false;
            txtLoopCount.Visible = false;
            txtWaitSeconds.Visible = false;
            btnComplete.Enabled = false;
            btnNextStep.Text = "Start";
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
            bool hasLoopBlock = false;
            bool hasWaitBlock = false;

            for (int i = 0; i < 4; i++)
            {
                string tag = pictures[i].Tag?.ToString() ?? "";
                blocks.Add(tag);

                if (tag.Contains("When clicked"))
                {
                    lblList.Text += "Handle a Click Event here\n";
                }
                else if (tag.Contains("For loop"))
                {
                    lblCountText.Text = "Loop count";
                    lblList.Text += "Initiate a For Loop here\n";
                    hasLoopBlock = true;
                }
                else if (tag.Contains("Wait"))
                {
                    lblWaitText.Text = "Seconds:";
                    lblList.Text += "Wait for X seconds\n";
                    hasWaitBlock = true;
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

            txtLoopCount.Visible = hasLoopBlock;
            lblCountText.Visible = hasLoopBlock;
            if (!hasLoopBlock) txtLoopCount.Text = "";

            txtWaitSeconds.Visible = hasWaitBlock;
            lblWaitText.Visible = hasWaitBlock;
            if (!hasWaitBlock) txtWaitSeconds.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LevelProgress.Lock3 = false;
            LevelProgress.Level3Completed = true;
            MessageBox.Show("Tutorial Completed! Now for the quiz levels!");
            previousForm.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            previousForm.Show();
            this.Close();
        }

        private int tutorialStep = 0;
        private readonly string[] tutorialTexts = new string[]
        {
            "Step 1: Welcome to Level 2! We will be using blocks to learn how to wait before prints. You can see the blocks below. Try dragging and dropping the when click block at the top, the for loop block under it, the wait block under that and the print block under it! Once done click next!",
            "Step 2: Now that you have the two blocks in the table, you can see another textbox appear, this is for how many seconds we want to wait before printing. Try typing a second between 1 ands 10 and type another number to repeat and anything to print. Once done click next!",
            "Step 3: Now press the run button at the bottom to run the blocks! Whatever you have written should be printed out and repeated how many times you wrote, but it waits the time you wrote before printing! Now you have finished and ready to do the quiz levels!"
        };

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
                pbForLoop.Visible = true;
                pbWait.Visible = true;
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

        private async void btnRun_Click(object sender, EventArgs e)
        {
            lblOutput.Text = "";
            blocks.Clear();

            for (int i = 0; i < 4; i++)
                blocks.Add(pictures[i].Tag?.ToString() ?? "");

            for (int i = 0; i < blocks.Count - 3; i++)
            {
                if (blocks[i].Contains("When clicked") &&
                    blocks[i + 1].Contains("For loop") &&
                    blocks[i + 2].Contains("Wait") &&
                    blocks[i + 3].Contains("Print"))
                {
                    if (!int.TryParse(txtLoopCount.Text, out int loopCount))
                    {
                        lblOutput.Text = "Invalid loop count.";
                        return;
                    }

                    if (!int.TryParse(txtWaitSeconds.Text, out int waitSeconds))
                    {
                        lblOutput.Text = "Invalid wait time.";
                        return;
                    }

                    for (int j = 0; j < loopCount; j++)
                    {
                        await Task.Delay(waitSeconds * 1000);
                        lblOutput.Text += txtPrintInput.Text + "\n";
                    }

                    return;
                }
            }

            lblOutput.Text = "No valid block sequence found.";
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
            txtLoopCount.Visible = false;
            txtWaitSeconds.Visible = false;
            txtPrintInput.Text = "";
            txtLoopCount.Text = "";
            txtWaitSeconds.Text = "";
            lblOutput.Text = "";
        }

        private void pbWait_Click(object sender, EventArgs e)
        {

        }
    }
}
