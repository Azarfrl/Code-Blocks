namespace Multi_Line
{
    partial class Form5
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
            this.btnPreviousStep = new System.Windows.Forms.Button();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblList = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.txtPrintInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tblCodeArea = new System.Windows.Forms.TableLayoutPanel();
            this.txtLoopCount = new System.Windows.Forms.TextBox();
            this.lblCountText = new System.Windows.Forms.Label();
            this.pbForLoop = new System.Windows.Forms.PictureBox();
            this.pbWhenClicked = new System.Windows.Forms.PictureBox();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.lblInput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbForLoop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhenClicked)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(662, 415);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(126, 23);
            this.btnComplete.TabIndex = 0;
            this.btnComplete.Text = "Complete Intermediate";
            this.btnComplete.UseVisualStyleBackColor = true;
            this.btnComplete.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(667, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Back to Level List";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnPreviousStep
            // 
            this.btnPreviousStep.Location = new System.Drawing.Point(93, 69);
            this.btnPreviousStep.Name = "btnPreviousStep";
            this.btnPreviousStep.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousStep.TabIndex = 14;
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
            this.btnNextStep.TabIndex = 13;
            this.btnNextStep.Tag = "";
            this.btnNextStep.Text = "Start";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(492, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "List of blocks:";
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(492, 87);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(46, 13);
            this.lblList.TabIndex = 17;
            this.lblList.Text = "             ";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(492, 276);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 13);
            this.lblOutput.TabIndex = 18;
            this.lblOutput.Text = "               ";
            // 
            // lblTutorial
            // 
            this.lblTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial.Location = new System.Drawing.Point(9, 9);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(575, 57);
            this.lblTutorial.TabIndex = 19;
            this.lblTutorial.Text = "label1";
            // 
            // txtPrintInput
            // 
            this.txtPrintInput.Location = new System.Drawing.Point(495, 217);
            this.txtPrintInput.Multiline = true;
            this.txtPrintInput.Name = "txtPrintInput";
            this.txtPrintInput.Size = new System.Drawing.Size(234, 63);
            this.txtPrintInput.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 23;
            this.label2.Text = "Available blocks:";
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(173, 415);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 25;
            this.btnRun.Tag = "";
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(254, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 24;
            this.btnClear.Tag = "";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tblCodeArea
            // 
            this.tblCodeArea.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.tblCodeArea.ColumnCount = 1;
            this.tblCodeArea.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblCodeArea.Location = new System.Drawing.Point(12, 145);
            this.tblCodeArea.Name = "tblCodeArea";
            this.tblCodeArea.RowCount = 4;
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tblCodeArea.Size = new System.Drawing.Size(155, 293);
            this.tblCodeArea.TabIndex = 26;
            // 
            // txtLoopCount
            // 
            this.txtLoopCount.Location = new System.Drawing.Point(495, 175);
            this.txtLoopCount.Name = "txtLoopCount";
            this.txtLoopCount.Size = new System.Drawing.Size(146, 20);
            this.txtLoopCount.TabIndex = 28;
            this.txtLoopCount.Visible = false;
            // 
            // lblCountText
            // 
            this.lblCountText.AutoSize = true;
            this.lblCountText.Location = new System.Drawing.Point(492, 159);
            this.lblCountText.Name = "lblCountText";
            this.lblCountText.Size = new System.Drawing.Size(67, 13);
            this.lblCountText.TabIndex = 29;
            this.lblCountText.Text = "                    ";
            // 
            // pbForLoop
            // 
            this.pbForLoop.Image = global::Multi_Line.Properties.Resources.forLoop1;
            this.pbForLoop.Location = new System.Drawing.Point(275, 257);
            this.pbForLoop.Name = "pbForLoop";
            this.pbForLoop.Size = new System.Drawing.Size(100, 47);
            this.pbForLoop.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbForLoop.TabIndex = 27;
            this.pbForLoop.TabStop = false;
            this.pbForLoop.Tag = "For loop";
            this.pbForLoop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbWhenClicked
            // 
            this.pbWhenClicked.Image = global::Multi_Line.Properties.Resources.whenClicked;
            this.pbWhenClicked.Location = new System.Drawing.Point(275, 145);
            this.pbWhenClicked.Name = "pbWhenClicked";
            this.pbWhenClicked.Size = new System.Drawing.Size(100, 50);
            this.pbWhenClicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWhenClicked.TabIndex = 22;
            this.pbWhenClicked.TabStop = false;
            this.pbWhenClicked.Tag = "When clicked";
            this.pbWhenClicked.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbPrint
            // 
            this.pbPrint.Image = global::Multi_Line.Properties.Resources.print;
            this.pbPrint.Location = new System.Drawing.Point(275, 201);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(100, 50);
            this.pbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrint.TabIndex = 21;
            this.pbPrint.TabStop = false;
            this.pbPrint.Tag = "Print";
            this.pbPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(492, 201);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(76, 13);
            this.lblInput.TabIndex = 30;
            this.lblInput.Text = "                       ";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInput);
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
            this.Controls.Add(this.lblTutorial);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPreviousStep);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnComplete);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbForLoop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhenClicked)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnPreviousStep;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.TextBox txtPrintInput;
        private System.Windows.Forms.PictureBox pbPrint;
        private System.Windows.Forms.PictureBox pbWhenClicked;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TableLayoutPanel tblCodeArea;
        private System.Windows.Forms.PictureBox pbForLoop;
        private System.Windows.Forms.TextBox txtLoopCount;
        private System.Windows.Forms.Label lblCountText;
        private System.Windows.Forms.Label lblInput;
    }
}