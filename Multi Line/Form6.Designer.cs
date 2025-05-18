namespace Multi_Line
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnComplete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblCountText = new System.Windows.Forms.Label();
            this.txtLoopCount = new System.Windows.Forms.TextBox();
            this.tblCodeArea = new System.Windows.Forms.TableLayoutPanel();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrintInput = new System.Windows.Forms.TextBox();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPreviousStep = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.txtWaitSeconds = new System.Windows.Forms.TextBox();
            this.lblWaitText = new System.Windows.Forms.Label();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.pbWait = new System.Windows.Forms.PictureBox();
            this.pbForLoop = new System.Windows.Forms.PictureBox();
            this.pbWhenClicked = new System.Windows.Forms.PictureBox();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.lblInput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhenClicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(673, 415);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(115, 23);
            this.btnComplete.TabIndex = 0;
            this.btnComplete.Text = "Complete Tutorial";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(665, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back to Level List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblCountText
            // 
            this.lblCountText.AutoSize = true;
            this.lblCountText.Location = new System.Drawing.Point(512, 204);
            this.lblCountText.Name = "lblCountText";
            this.lblCountText.Size = new System.Drawing.Size(49, 13);
            this.lblCountText.TabIndex = 44;
            this.lblCountText.Text = "              ";
            this.lblCountText.Visible = false;
            // 
            // txtLoopCount
            // 
            this.txtLoopCount.Location = new System.Drawing.Point(515, 220);
            this.txtLoopCount.Name = "txtLoopCount";
            this.txtLoopCount.Size = new System.Drawing.Size(146, 20);
            this.txtLoopCount.TabIndex = 43;
            this.txtLoopCount.Visible = false;
            // 
            // tblCodeArea
            // 
            this.tblCodeArea.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblCodeArea.ColumnCount = 1;
            this.tblCodeArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCodeArea.Location = new System.Drawing.Point(13, 145);
            this.tblCodeArea.Name = "tblCodeArea";
            this.tblCodeArea.RowCount = 4;
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.Size = new System.Drawing.Size(155, 293);
            this.tblCodeArea.TabIndex = 41;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(183, 415);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 40;
            this.btnRun.Tag = "";
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(264, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 39;
            this.btnClear.Tag = "";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "Available blocks:";
            // 
            // txtPrintInput
            // 
            this.txtPrintInput.Location = new System.Drawing.Point(515, 259);
            this.txtPrintInput.Multiline = true;
            this.txtPrintInput.Name = "txtPrintInput";
            this.txtPrintInput.Size = new System.Drawing.Size(234, 63);
            this.txtPrintInput.TabIndex = 35;
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(512, 321);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 13);
            this.lblOutput.TabIndex = 34;
            this.lblOutput.Text = "               ";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(512, 92);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(46, 13);
            this.lblList.TabIndex = 33;
            this.lblList.Text = "             ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(512, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "List of blocks:";
            // 
            // btnPreviousStep
            // 
            this.btnPreviousStep.Location = new System.Drawing.Point(93, 69);
            this.btnPreviousStep.Name = "btnPreviousStep";
            this.btnPreviousStep.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousStep.TabIndex = 31;
            this.btnPreviousStep.Text = "Back";
            this.btnPreviousStep.UseVisualStyleBackColor = true;
            this.btnPreviousStep.Visible = false;
            this.btnPreviousStep.Click += new System.EventHandler(this.btnPreviousStep_Click);
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(12, 69);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(75, 23);
            this.btnNextStep.TabIndex = 30;
            this.btnNextStep.Tag = "";
            this.btnNextStep.Text = "Start";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // txtWaitSeconds
            // 
            this.txtWaitSeconds.Location = new System.Drawing.Point(515, 181);
            this.txtWaitSeconds.Name = "txtWaitSeconds";
            this.txtWaitSeconds.Size = new System.Drawing.Size(146, 20);
            this.txtWaitSeconds.TabIndex = 45;
            this.txtWaitSeconds.Visible = false;
            // 
            // lblWaitText
            // 
            this.lblWaitText.AutoSize = true;
            this.lblWaitText.Location = new System.Drawing.Point(512, 161);
            this.lblWaitText.Name = "lblWaitText";
            this.lblWaitText.Size = new System.Drawing.Size(64, 13);
            this.lblWaitText.TabIndex = 46;
            this.lblWaitText.Text = "                   ";
            this.lblWaitText.Visible = false;
            // 
            // lblTutorial
            // 
            this.lblTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial.Location = new System.Drawing.Point(12, 9);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(597, 57);
            this.lblTutorial.TabIndex = 47;
            this.lblTutorial.Text = "label1";
            // 
            // pbWait
            // 
            this.pbWait.Image = global::Multi_Line.Properties.Resources.wait1;
            this.pbWait.Location = new System.Drawing.Point(305, 290);
            this.pbWait.Name = "pbWait";
            this.pbWait.Size = new System.Drawing.Size(100, 50);
            this.pbWait.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWait.TabIndex = 48;
            this.pbWait.TabStop = false;
            this.pbWait.Tag = "Wait";
            this.pbWait.Click += new System.EventHandler(this.pbWait_Click);
            this.pbWait.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbForLoop
            // 
            this.pbForLoop.Image = global::Multi_Line.Properties.Resources.forLoop1;
            this.pbForLoop.Location = new System.Drawing.Point(305, 237);
            this.pbForLoop.Name = "pbForLoop";
            this.pbForLoop.Size = new System.Drawing.Size(100, 47);
            this.pbForLoop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbForLoop.TabIndex = 42;
            this.pbForLoop.TabStop = false;
            this.pbForLoop.Tag = "For loop";
            this.pbForLoop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbWhenClicked
            // 
            this.pbWhenClicked.Image = global::Multi_Line.Properties.Resources.whenClicked;
            this.pbWhenClicked.Location = new System.Drawing.Point(305, 125);
            this.pbWhenClicked.Name = "pbWhenClicked";
            this.pbWhenClicked.Size = new System.Drawing.Size(100, 50);
            this.pbWhenClicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWhenClicked.TabIndex = 37;
            this.pbWhenClicked.TabStop = false;
            this.pbWhenClicked.Tag = "When clicked";
            this.pbWhenClicked.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbPrint
            // 
            this.pbPrint.Image = global::Multi_Line.Properties.Resources.print;
            this.pbPrint.Location = new System.Drawing.Point(305, 181);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(100, 50);
            this.pbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrint.TabIndex = 36;
            this.pbPrint.TabStop = false;
            this.pbPrint.Tag = "Print";
            this.pbPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(512, 243);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(76, 13);
            this.lblInput.TabIndex = 49;
            this.lblInput.Text = "                       ";
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.pbWait);
            this.Controls.Add(this.lblTutorial);
            this.Controls.Add(this.lblWaitText);
            this.Controls.Add(this.txtWaitSeconds);
            this.Controls.Add(this.lblCountText);
            this.Controls.Add(this.txtLoopCount);
            this.Controls.Add(this.pbForLoop);
            this.Controls.Add(this.tblCodeArea);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbWhenClicked);
            this.Controls.Add(this.pbPrint);
            this.Controls.Add(this.txtPrintInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreviousStep);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnComplete);
            this.Name = "Form6";
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.Form6_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbWait)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbForLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhenClicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblCountText;
        private System.Windows.Forms.TextBox txtLoopCount;
        private System.Windows.Forms.PictureBox pbForLoop;
        private System.Windows.Forms.TableLayoutPanel tblCodeArea;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbWhenClicked;
        private System.Windows.Forms.PictureBox pbPrint;
        private System.Windows.Forms.TextBox txtPrintInput;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPreviousStep;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.TextBox txtWaitSeconds;
        private System.Windows.Forms.Label lblWaitText;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.PictureBox pbWait;
        private System.Windows.Forms.Label lblInput;
    }
}