namespace Multi_Line
{
    partial class Form4
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
            this.tblCodeArea = new System.Windows.Forms.TableLayoutPanel();
            this.lblList = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblTutorial = new System.Windows.Forms.Label();
            this.btnNextStep = new System.Windows.Forms.Button();
            this.btnPreviousStep = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.pbPrint = new System.Windows.Forms.PictureBox();
            this.pbWhenClicked = new System.Windows.Forms.PictureBox();
            this.txtPrintInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblInput = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhenClicked)).BeginInit();
            this.SuspendLayout();
            // 
            // btnComplete
            // 
            this.btnComplete.Location = new System.Drawing.Point(674, 415);
            this.btnComplete.Name = "btnComplete";
            this.btnComplete.Size = new System.Drawing.Size(114, 23);
            this.btnComplete.TabIndex = 0;
            this.btnComplete.Text = "Complete Basics";
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
            this.tblCodeArea.TabIndex = 2;
            // 
            // lblList
            // 
            this.lblList.AutoSize = true;
            this.lblList.Location = new System.Drawing.Point(419, 145);
            this.lblList.Name = "lblList";
            this.lblList.Size = new System.Drawing.Size(46, 13);
            this.lblList.TabIndex = 5;
            this.lblList.Text = "             ";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(419, 277);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(52, 13);
            this.lblOutput.TabIndex = 6;
            this.lblOutput.Text = "               ";
            // 
            // lblTutorial
            // 
            this.lblTutorial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTutorial.Location = new System.Drawing.Point(9, 12);
            this.lblTutorial.Name = "lblTutorial";
            this.lblTutorial.Size = new System.Drawing.Size(532, 55);
            this.lblTutorial.TabIndex = 9;
            this.lblTutorial.Text = "label1";
            // 
            // btnNextStep
            // 
            this.btnNextStep.Location = new System.Drawing.Point(12, 70);
            this.btnNextStep.Name = "btnNextStep";
            this.btnNextStep.Size = new System.Drawing.Size(75, 23);
            this.btnNextStep.TabIndex = 10;
            this.btnNextStep.Tag = "";
            this.btnNextStep.Text = "Start";
            this.btnNextStep.UseVisualStyleBackColor = true;
            this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
            // 
            // btnPreviousStep
            // 
            this.btnPreviousStep.Location = new System.Drawing.Point(93, 70);
            this.btnPreviousStep.Name = "btnPreviousStep";
            this.btnPreviousStep.Size = new System.Drawing.Size(75, 23);
            this.btnPreviousStep.TabIndex = 12;
            this.btnPreviousStep.Text = "Back";
            this.btnPreviousStep.UseVisualStyleBackColor = true;
            this.btnPreviousStep.Visible = false;
            this.btnPreviousStep.Click += new System.EventHandler(this.btnPreviousStep_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(273, 415);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 12;
            this.btnClear.Tag = "";
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(192, 415);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(75, 23);
            this.btnRun.TabIndex = 14;
            this.btnRun.Tag = "";
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // pbPrint
            // 
            this.pbPrint.Image = global::Multi_Line.Properties.Resources.print;
            this.pbPrint.Location = new System.Drawing.Point(273, 211);
            this.pbPrint.Name = "pbPrint";
            this.pbPrint.Size = new System.Drawing.Size(100, 50);
            this.pbPrint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPrint.TabIndex = 4;
            this.pbPrint.TabStop = false;
            this.pbPrint.Tag = "Print";
            this.pbPrint.Click += new System.EventHandler(this.pbPrint_Click);
            this.pbPrint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // pbWhenClicked
            // 
            this.pbWhenClicked.Image = global::Multi_Line.Properties.Resources.whenClicked;
            this.pbWhenClicked.Location = new System.Drawing.Point(273, 145);
            this.pbWhenClicked.Name = "pbWhenClicked";
            this.pbWhenClicked.Size = new System.Drawing.Size(100, 50);
            this.pbWhenClicked.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbWhenClicked.TabIndex = 3;
            this.pbWhenClicked.TabStop = false;
            this.pbWhenClicked.Tag = "When clicked";
            this.pbWhenClicked.MouseDown += new System.Windows.Forms.MouseEventHandler(this.codeBlock_MouseDown);
            // 
            // txtPrintInput
            // 
            this.txtPrintInput.Location = new System.Drawing.Point(422, 211);
            this.txtPrintInput.Multiline = true;
            this.txtPrintInput.Name = "txtPrintInput";
            this.txtPrintInput.Size = new System.Drawing.Size(234, 63);
            this.txtPrintInput.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(419, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "List of blocks:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Available blocks:";
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Location = new System.Drawing.Point(419, 195);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(76, 13);
            this.lblInput.TabIndex = 17;
            this.lblInput.Text = "                       ";
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnPreviousStep);
            this.Controls.Add(this.btnNextStep);
            this.Controls.Add(this.lblTutorial);
            this.Controls.Add(this.txtPrintInput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblList);
            this.Controls.Add(this.pbPrint);
            this.Controls.Add(this.pbWhenClicked);
            this.Controls.Add(this.tblCodeArea);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnComplete);
            this.Name = "Form4";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPrint)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbWhenClicked)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnComplete;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tblCodeArea;
        private System.Windows.Forms.PictureBox pbWhenClicked;
        private System.Windows.Forms.PictureBox pbPrint;
        private System.Windows.Forms.Label lblList;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblTutorial;
        private System.Windows.Forms.Button btnNextStep;
        private System.Windows.Forms.Button btnPreviousStep;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.TextBox txtPrintInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblInput;
    }
}