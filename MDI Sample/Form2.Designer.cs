namespace MDI_Sample
{
    partial class frmMathQuizMC
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMathQuizMC));
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lbResult = new System.Windows.Forms.Label();
            this.lbPercentage = new System.Windows.Forms.Label();
            this.lbCountDownTimer = new System.Windows.Forms.Label();
            this.lbOperation = new System.Windows.Forms.Label();
            this.lbQuestionType = new System.Windows.Forms.Label();
            this.lbQuestionLevel = new System.Windows.Forms.Label();
            this.lbQuestionsNumber = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.rbOpt1 = new System.Windows.Forms.RadioButton();
            this.rbOpt4 = new System.Windows.Forms.RadioButton();
            this.rbOpt3 = new System.Windows.Forms.RadioButton();
            this.rbOpt2 = new System.Windows.Forms.RadioButton();
            this.btnCheck = new System.Windows.Forms.Button();
            this.pnlAnswer = new System.Windows.Forms.Panel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.lbOper = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmNext = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox3.SuspendLayout();
            this.pnlAnswer.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lbResult);
            this.groupBox3.Controls.Add(this.lbPercentage);
            this.groupBox3.Controls.Add(this.lbCountDownTimer);
            this.groupBox3.Controls.Add(this.lbOperation);
            this.groupBox3.Controls.Add(this.lbQuestionType);
            this.groupBox3.Controls.Add(this.lbQuestionLevel);
            this.groupBox3.Controls.Add(this.lbQuestionsNumber);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(669, 29);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(480, 441);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Quiz Status";
            // 
            // lbResult
            // 
            this.lbResult.AutoSize = true;
            this.lbResult.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbResult.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbResult.Location = new System.Drawing.Point(129, 378);
            this.lbResult.Name = "lbResult";
            this.lbResult.Size = new System.Drawing.Size(158, 37);
            this.lbResult.TabIndex = 19;
            this.lbResult.Text = "In Progress";
            // 
            // lbPercentage
            // 
            this.lbPercentage.AutoSize = true;
            this.lbPercentage.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPercentage.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbPercentage.Location = new System.Drawing.Point(191, 330);
            this.lbPercentage.Name = "lbPercentage";
            this.lbPercentage.Size = new System.Drawing.Size(56, 37);
            this.lbPercentage.TabIndex = 18;
            this.lbPercentage.Text = "0%";
            // 
            // lbCountDownTimer
            // 
            this.lbCountDownTimer.AutoSize = true;
            this.lbCountDownTimer.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCountDownTimer.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbCountDownTimer.Location = new System.Drawing.Point(283, 279);
            this.lbCountDownTimer.Name = "lbCountDownTimer";
            this.lbCountDownTimer.Size = new System.Drawing.Size(80, 37);
            this.lbCountDownTimer.TabIndex = 17;
            this.lbCountDownTimer.Text = "02:00";
            // 
            // lbOperation
            // 
            this.lbOperation.AutoSize = true;
            this.lbOperation.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOperation.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbOperation.Location = new System.Drawing.Point(177, 227);
            this.lbOperation.Name = "lbOperation";
            this.lbOperation.Size = new System.Drawing.Size(130, 37);
            this.lbOperation.TabIndex = 16;
            this.lbOperation.Text = "Addition";
            // 
            // lbQuestionType
            // 
            this.lbQuestionType.AutoSize = true;
            this.lbQuestionType.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestionType.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbQuestionType.Location = new System.Drawing.Point(230, 179);
            this.lbQuestionType.Name = "lbQuestionType";
            this.lbQuestionType.Size = new System.Drawing.Size(216, 37);
            this.lbQuestionType.TabIndex = 15;
            this.lbQuestionType.Text = "Multiple Choice";
            // 
            // lbQuestionLevel
            // 
            this.lbQuestionLevel.AutoSize = true;
            this.lbQuestionLevel.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestionLevel.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbQuestionLevel.Location = new System.Drawing.Point(244, 128);
            this.lbQuestionLevel.Name = "lbQuestionLevel";
            this.lbQuestionLevel.Size = new System.Drawing.Size(66, 37);
            this.lbQuestionLevel.TabIndex = 14;
            this.lbQuestionLevel.Text = "Mix";
            // 
            // lbQuestionsNumber
            // 
            this.lbQuestionsNumber.AutoSize = true;
            this.lbQuestionsNumber.Font = new System.Drawing.Font("Palatino Linotype", 14F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbQuestionsNumber.ForeColor = System.Drawing.Color.Cornsilk;
            this.lbQuestionsNumber.Location = new System.Drawing.Point(295, 80);
            this.lbQuestionsNumber.Name = "lbQuestionsNumber";
            this.lbQuestionsNumber.Size = new System.Drawing.Size(31, 37);
            this.lbQuestionsNumber.TabIndex = 13;
            this.lbQuestionsNumber.Text = "1";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 380);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 35);
            this.label7.TabIndex = 12;
            this.label7.Text = "Result:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 35);
            this.label6.TabIndex = 11;
            this.label6.Text = "Percentage:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(263, 35);
            this.label5.TabIndex = 10;
            this.label5.Text = "CountDown Timer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 230);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 35);
            this.label4.TabIndex = 9;
            this.label4.Text = "Operation:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 35);
            this.label3.TabIndex = 8;
            this.label3.Text = "Questions Type:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(236, 35);
            this.label2.TabIndex = 7;
            this.label2.Text = "Questions Level :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(277, 35);
            this.label1.TabIndex = 6;
            this.label1.Text = "Questions Number :";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(836, 516);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(148, 55);
            this.btnStart.TabIndex = 6;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(1001, 516);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 55);
            this.btnExit.TabIndex = 7;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnNext
            // 
            this.btnNext.Enabled = false;
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(669, 516);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(148, 55);
            this.btnNext.TabIndex = 8;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(213, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(123, 35);
            this.label8.TabIndex = 9;
            this.label8.Text = "What Is ";
            // 
            // rbOpt1
            // 
            this.rbOpt1.AutoSize = true;
            this.rbOpt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpt1.Location = new System.Drawing.Point(83, 37);
            this.rbOpt1.Name = "rbOpt1";
            this.rbOpt1.Size = new System.Drawing.Size(52, 33);
            this.rbOpt1.TabIndex = 10;
            this.rbOpt1.TabStop = true;
            this.rbOpt1.Text = "6";
            this.rbOpt1.UseVisualStyleBackColor = true;
            this.rbOpt1.CheckedChanged += new System.EventHandler(this.rbOpt1_CheckedChanged);
            // 
            // rbOpt4
            // 
            this.rbOpt4.AutoSize = true;
            this.rbOpt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpt4.Location = new System.Drawing.Point(83, 241);
            this.rbOpt4.Name = "rbOpt4";
            this.rbOpt4.Size = new System.Drawing.Size(52, 33);
            this.rbOpt4.TabIndex = 11;
            this.rbOpt4.TabStop = true;
            this.rbOpt4.Text = "7";
            this.rbOpt4.UseVisualStyleBackColor = true;
            this.rbOpt4.CheckedChanged += new System.EventHandler(this.rbOpt4_CheckedChanged);
            // 
            // rbOpt3
            // 
            this.rbOpt3.AutoSize = true;
            this.rbOpt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpt3.Location = new System.Drawing.Point(83, 173);
            this.rbOpt3.Name = "rbOpt3";
            this.rbOpt3.Size = new System.Drawing.Size(52, 33);
            this.rbOpt3.TabIndex = 12;
            this.rbOpt3.TabStop = true;
            this.rbOpt3.Text = "4";
            this.rbOpt3.UseVisualStyleBackColor = true;
            this.rbOpt3.CheckedChanged += new System.EventHandler(this.rbOpt3_CheckedChanged);
            // 
            // rbOpt2
            // 
            this.rbOpt2.AutoSize = true;
            this.rbOpt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpt2.Location = new System.Drawing.Point(83, 105);
            this.rbOpt2.Name = "rbOpt2";
            this.rbOpt2.Size = new System.Drawing.Size(52, 33);
            this.rbOpt2.TabIndex = 13;
            this.rbOpt2.TabStop = true;
            this.rbOpt2.Text = "2";
            this.rbOpt2.UseVisualStyleBackColor = true;
            this.rbOpt2.CheckedChanged += new System.EventHandler(this.rbOpt2_CheckedChanged);
            // 
            // btnCheck
            // 
            this.btnCheck.Enabled = false;
            this.btnCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheck.Location = new System.Drawing.Point(249, 445);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(148, 55);
            this.btnCheck.TabIndex = 14;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // pnlAnswer
            // 
            this.pnlAnswer.Controls.Add(this.rbOpt2);
            this.pnlAnswer.Controls.Add(this.rbOpt3);
            this.pnlAnswer.Controls.Add(this.rbOpt4);
            this.pnlAnswer.Controls.Add(this.rbOpt1);
            this.pnlAnswer.Location = new System.Drawing.Point(214, 141);
            this.pnlAnswer.Name = "pnlAnswer";
            this.pnlAnswer.Size = new System.Drawing.Size(227, 287);
            this.pnlAnswer.TabIndex = 18;
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // lbOper
            // 
            this.lbOper.AutoSize = true;
            this.lbOper.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOper.Location = new System.Drawing.Point(330, 73);
            this.lbOper.Name = "lbOper";
            this.lbOper.Size = new System.Drawing.Size(147, 35);
            this.lbOper.TabIndex = 20;
            this.lbOper.Text = "Operation";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStart,
            this.tsmNext,
            this.tsmExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(185, 100);
            // 
            // tsmStart
            // 
            this.tsmStart.Name = "tsmStart";
            this.tsmStart.ShortcutKeyDisplayString = "Ctrl+S";
            this.tsmStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmStart.Size = new System.Drawing.Size(184, 32);
            this.tsmStart.Text = "Start";
            this.tsmStart.Click += new System.EventHandler(this.tsmStart_Click);
            // 
            // tsmNext
            // 
            this.tsmNext.Name = "tsmNext";
            this.tsmNext.ShortcutKeyDisplayString = "Ctrl+N";
            this.tsmNext.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.tsmNext.Size = new System.Drawing.Size(184, 32);
            this.tsmNext.Text = "Next";
            this.tsmNext.Click += new System.EventHandler(this.tsmNext_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeyDisplayString = "Ctrl+E";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmExit.Size = new System.Drawing.Size(184, 32);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // frmMathQuizMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1178, 620);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lbOper);
            this.Controls.Add(this.pnlAnswer);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.groupBox3);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMathQuizMC";
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.frmMathQuizMC_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnlAnswer.ResumeLayout(false);
            this.pnlAnswer.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbQuestionLevel;
        private System.Windows.Forms.Label lbQuestionsNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbQuestionType;
        private System.Windows.Forms.Label lbOperation;
        private System.Windows.Forms.Label lbCountDownTimer;
        private System.Windows.Forms.Label lbResult;
        private System.Windows.Forms.Label lbPercentage;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbOpt1;
        private System.Windows.Forms.RadioButton rbOpt4;
        private System.Windows.Forms.RadioButton rbOpt3;
        private System.Windows.Forms.RadioButton rbOpt2;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Panel pnlAnswer;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Label lbOper;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmStart;
        private System.Windows.Forms.ToolStripMenuItem tsmNext;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
    }
}