namespace MDI_Sample
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.gbQueLevel = new System.Windows.Forms.GroupBox();
            this.rbMix = new System.Windows.Forms.RadioButton();
            this.rbHard = new System.Windows.Forms.RadioButton();
            this.rbMedium = new System.Windows.Forms.RadioButton();
            this.rbEasy = new System.Windows.Forms.RadioButton();
            this.gbQueType = new System.Windows.Forms.GroupBox();
            this.rbTrueOrFalse = new System.Windows.Forms.RadioButton();
            this.rbFillInTheBlanck = new System.Windows.Forms.RadioButton();
            this.rbMultiChoice = new System.Windows.Forms.RadioButton();
            this.gbOperation = new System.Windows.Forms.GroupBox();
            this.rbOpMix = new System.Windows.Forms.RadioButton();
            this.rbDiv = new System.Windows.Forms.RadioButton();
            this.rbMulti = new System.Windows.Forms.RadioButton();
            this.rbSub = new System.Windows.Forms.RadioButton();
            this.rbAdd = new System.Windows.Forms.RadioButton();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.nudNumOfQue = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmStart = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.gbQueLevel.SuspendLayout();
            this.gbQueType.SuspendLayout();
            this.gbOperation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfQue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(376, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(303, 69);
            this.label1.TabIndex = 0;
            this.label1.Text = "Math Quiz";
            // 
            // gbQueLevel
            // 
            this.gbQueLevel.Controls.Add(this.rbMix);
            this.gbQueLevel.Controls.Add(this.rbHard);
            this.gbQueLevel.Controls.Add(this.rbMedium);
            this.gbQueLevel.Controls.Add(this.rbEasy);
            this.gbQueLevel.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQueLevel.Location = new System.Drawing.Point(159, 180);
            this.gbQueLevel.Name = "gbQueLevel";
            this.gbQueLevel.Size = new System.Drawing.Size(634, 134);
            this.gbQueLevel.TabIndex = 1;
            this.gbQueLevel.TabStop = false;
            this.gbQueLevel.Text = "Question Level";
            // 
            // rbMix
            // 
            this.rbMix.AutoSize = true;
            this.rbMix.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMix.Location = new System.Drawing.Point(508, 68);
            this.rbMix.Name = "rbMix";
            this.rbMix.Size = new System.Drawing.Size(89, 37);
            this.rbMix.TabIndex = 3;
            this.rbMix.TabStop = true;
            this.rbMix.Tag = "4";
            this.rbMix.Text = "Mix";
            this.rbMix.UseVisualStyleBackColor = true;
            this.rbMix.CheckedChanged += new System.EventHandler(this.rbMix_CheckedChanged);
            // 
            // rbHard
            // 
            this.rbHard.AutoSize = true;
            this.rbHard.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbHard.Location = new System.Drawing.Point(367, 68);
            this.rbHard.Name = "rbHard";
            this.rbHard.Size = new System.Drawing.Size(107, 37);
            this.rbHard.TabIndex = 2;
            this.rbHard.TabStop = true;
            this.rbHard.Tag = "3";
            this.rbHard.Text = "Hard";
            this.rbHard.UseVisualStyleBackColor = true;
            this.rbHard.CheckedChanged += new System.EventHandler(this.rbHard_CheckedChanged);
            // 
            // rbMedium
            // 
            this.rbMedium.AutoSize = true;
            this.rbMedium.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMedium.Location = new System.Drawing.Point(184, 68);
            this.rbMedium.Name = "rbMedium";
            this.rbMedium.Size = new System.Drawing.Size(149, 37);
            this.rbMedium.TabIndex = 1;
            this.rbMedium.TabStop = true;
            this.rbMedium.Tag = "2";
            this.rbMedium.Text = "Medium";
            this.rbMedium.UseVisualStyleBackColor = true;
            this.rbMedium.CheckedChanged += new System.EventHandler(this.rbMedium_CheckedChanged);
            // 
            // rbEasy
            // 
            this.rbEasy.AutoSize = true;
            this.rbEasy.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEasy.Location = new System.Drawing.Point(43, 68);
            this.rbEasy.Name = "rbEasy";
            this.rbEasy.Size = new System.Drawing.Size(107, 37);
            this.rbEasy.TabIndex = 0;
            this.rbEasy.TabStop = true;
            this.rbEasy.Tag = "1";
            this.rbEasy.Text = "Easy";
            this.rbEasy.UseVisualStyleBackColor = true;
            this.rbEasy.CheckedChanged += new System.EventHandler(this.rbEasy_CheckedChanged);
            // 
            // gbQueType
            // 
            this.gbQueType.Controls.Add(this.rbTrueOrFalse);
            this.gbQueType.Controls.Add(this.rbFillInTheBlanck);
            this.gbQueType.Controls.Add(this.rbMultiChoice);
            this.gbQueType.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbQueType.Location = new System.Drawing.Point(159, 338);
            this.gbQueType.Name = "gbQueType";
            this.gbQueType.Size = new System.Drawing.Size(891, 134);
            this.gbQueType.TabIndex = 4;
            this.gbQueType.TabStop = false;
            this.gbQueType.Text = "Question Type";
            // 
            // rbTrueOrFalse
            // 
            this.rbTrueOrFalse.AutoSize = true;
            this.rbTrueOrFalse.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbTrueOrFalse.Location = new System.Drawing.Point(627, 68);
            this.rbTrueOrFalse.Name = "rbTrueOrFalse";
            this.rbTrueOrFalse.Size = new System.Drawing.Size(240, 37);
            this.rbTrueOrFalse.TabIndex = 2;
            this.rbTrueOrFalse.TabStop = true;
            this.rbTrueOrFalse.Tag = "3";
            this.rbTrueOrFalse.Text = "True Or False";
            this.rbTrueOrFalse.UseVisualStyleBackColor = true;
            this.rbTrueOrFalse.CheckedChanged += new System.EventHandler(this.rbTrueOrFalse_CheckedChanged);
            // 
            // rbFillInTheBlanck
            // 
            this.rbFillInTheBlanck.AutoSize = true;
            this.rbFillInTheBlanck.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbFillInTheBlanck.Location = new System.Drawing.Point(310, 68);
            this.rbFillInTheBlanck.Name = "rbFillInTheBlanck";
            this.rbFillInTheBlanck.Size = new System.Drawing.Size(291, 37);
            this.rbFillInTheBlanck.TabIndex = 1;
            this.rbFillInTheBlanck.TabStop = true;
            this.rbFillInTheBlanck.Tag = "2";
            this.rbFillInTheBlanck.Text = "Fill In The Blanck";
            this.rbFillInTheBlanck.UseVisualStyleBackColor = true;
            this.rbFillInTheBlanck.CheckedChanged += new System.EventHandler(this.rbFillInTheBlanck_CheckedChanged);
            // 
            // rbMultiChoice
            // 
            this.rbMultiChoice.AutoSize = true;
            this.rbMultiChoice.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMultiChoice.Location = new System.Drawing.Point(22, 68);
            this.rbMultiChoice.Name = "rbMultiChoice";
            this.rbMultiChoice.Size = new System.Drawing.Size(261, 37);
            this.rbMultiChoice.TabIndex = 0;
            this.rbMultiChoice.TabStop = true;
            this.rbMultiChoice.Tag = "1";
            this.rbMultiChoice.Text = "Multiple Choice";
            this.rbMultiChoice.UseVisualStyleBackColor = true;
            this.rbMultiChoice.CheckedChanged += new System.EventHandler(this.rbMultiChoice_CheckedChanged);
            // 
            // gbOperation
            // 
            this.gbOperation.Controls.Add(this.rbOpMix);
            this.gbOperation.Controls.Add(this.rbDiv);
            this.gbOperation.Controls.Add(this.rbMulti);
            this.gbOperation.Controls.Add(this.rbSub);
            this.gbOperation.Controls.Add(this.rbAdd);
            this.gbOperation.Font = new System.Drawing.Font("Monotype Corsiva", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbOperation.Location = new System.Drawing.Point(855, 12);
            this.gbOperation.Name = "gbOperation";
            this.gbOperation.Size = new System.Drawing.Size(301, 302);
            this.gbOperation.TabIndex = 4;
            this.gbOperation.TabStop = false;
            this.gbOperation.Text = "Operation";
            // 
            // rbOpMix
            // 
            this.rbOpMix.AutoSize = true;
            this.rbOpMix.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbOpMix.Location = new System.Drawing.Point(43, 240);
            this.rbOpMix.Name = "rbOpMix";
            this.rbOpMix.Size = new System.Drawing.Size(89, 37);
            this.rbOpMix.TabIndex = 4;
            this.rbOpMix.TabStop = true;
            this.rbOpMix.Tag = "5";
            this.rbOpMix.Text = "Mix";
            this.rbOpMix.UseVisualStyleBackColor = true;
            this.rbOpMix.CheckedChanged += new System.EventHandler(this.rbOpMix_CheckedChanged);
            // 
            // rbDiv
            // 
            this.rbDiv.AutoSize = true;
            this.rbDiv.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbDiv.Location = new System.Drawing.Point(43, 197);
            this.rbDiv.Name = "rbDiv";
            this.rbDiv.Size = new System.Drawing.Size(152, 37);
            this.rbDiv.TabIndex = 3;
            this.rbDiv.TabStop = true;
            this.rbDiv.Tag = "4";
            this.rbDiv.Text = "Division";
            this.rbDiv.UseVisualStyleBackColor = true;
            this.rbDiv.CheckedChanged += new System.EventHandler(this.rbDiv_CheckedChanged);
            // 
            // rbMulti
            // 
            this.rbMulti.AutoSize = true;
            this.rbMulti.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMulti.Location = new System.Drawing.Point(43, 154);
            this.rbMulti.Name = "rbMulti";
            this.rbMulti.Size = new System.Drawing.Size(230, 37);
            this.rbMulti.TabIndex = 2;
            this.rbMulti.TabStop = true;
            this.rbMulti.Tag = "3";
            this.rbMulti.Text = "Multiplication";
            this.rbMulti.UseVisualStyleBackColor = true;
            this.rbMulti.CheckedChanged += new System.EventHandler(this.rbMulti_CheckedChanged);
            // 
            // rbSub
            // 
            this.rbSub.AutoSize = true;
            this.rbSub.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbSub.Location = new System.Drawing.Point(43, 111);
            this.rbSub.Name = "rbSub";
            this.rbSub.Size = new System.Drawing.Size(205, 37);
            this.rbSub.TabIndex = 1;
            this.rbSub.TabStop = true;
            this.rbSub.Tag = "2";
            this.rbSub.Text = "Subtraction";
            this.rbSub.UseVisualStyleBackColor = true;
            this.rbSub.CheckedChanged += new System.EventHandler(this.rbSub_CheckedChanged);
            // 
            // rbAdd
            // 
            this.rbAdd.AutoSize = true;
            this.rbAdd.Font = new System.Drawing.Font("MS PGothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbAdd.Location = new System.Drawing.Point(43, 68);
            this.rbAdd.Name = "rbAdd";
            this.rbAdd.Size = new System.Drawing.Size(157, 37);
            this.rbAdd.TabIndex = 0;
            this.rbAdd.TabStop = true;
            this.rbAdd.Tag = "1";
            this.rbAdd.Text = "Addition";
            this.rbAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rbAdd.UseVisualStyleBackColor = true;
            this.rbAdd.CheckedChanged += new System.EventHandler(this.rbAdd_CheckedChanged);
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnStart.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.White;
            this.btnStart.Location = new System.Drawing.Point(448, 514);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(185, 62);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExit.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Location = new System.Drawing.Point(981, 544);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(185, 62);
            this.btnExit.TabIndex = 5;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // nudNumOfQue
            // 
            this.nudNumOfQue.BackColor = System.Drawing.Color.Gainsboro;
            this.nudNumOfQue.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudNumOfQue.Location = new System.Drawing.Point(663, 526);
            this.nudNumOfQue.Name = "nudNumOfQue";
            this.nudNumOfQue.Size = new System.Drawing.Size(167, 39);
            this.nudNumOfQue.TabIndex = 7;
            this.nudNumOfQue.ValueChanged += new System.EventHandler(this.nudNumOfQue_ValueChanged);
            // 
            // numericUpDown3
            // 
            this.numericUpDown3.BackColor = System.Drawing.Color.Gainsboro;
            this.numericUpDown3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown3.Location = new System.Drawing.Point(251, 526);
            this.numericUpDown3.Name = "numericUpDown3";
            this.numericUpDown3.Size = new System.Drawing.Size(167, 39);
            this.numericUpDown3.TabIndex = 8;
            this.numericUpDown3.ValueChanged += new System.EventHandler(this.numericUpDown3_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(648, 498);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(220, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Number Of Questions";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 498);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Count Down Timer";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDate.Location = new System.Drawing.Point(12, 12);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(67, 29);
            this.lbDate.TabIndex = 11;
            this.lbDate.Text = "Date";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(12, 46);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(73, 29);
            this.lbTime.TabIndex = 12;
            this.lbTime.Text = "Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmStart,
            this.tsmExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(182, 68);
            // 
            // tsmStart
            // 
            this.tsmStart.Name = "tsmStart";
            this.tsmStart.ShortcutKeyDisplayString = "Ctrl+S";
            this.tsmStart.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.tsmStart.Size = new System.Drawing.Size(181, 32);
            this.tsmStart.Text = "Start";
            this.tsmStart.Click += new System.EventHandler(this.tsmStart_Click);
            // 
            // tsmExit
            // 
            this.tsmExit.Name = "tsmExit";
            this.tsmExit.ShortcutKeyDisplayString = "Ctrl+E";
            this.tsmExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.tsmExit.Size = new System.Drawing.Size(181, 32);
            this.tsmExit.Text = "Exit";
            this.tsmExit.Click += new System.EventHandler(this.tsmExit_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1178, 620);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown3);
            this.Controls.Add(this.nudNumOfQue);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.gbOperation);
            this.Controls.Add(this.gbQueType);
            this.Controls.Add(this.gbQueLevel);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmHome";
            this.Text = "Math Quiz";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbQueLevel.ResumeLayout(false);
            this.gbQueLevel.PerformLayout();
            this.gbQueType.ResumeLayout(false);
            this.gbQueType.PerformLayout();
            this.gbOperation.ResumeLayout(false);
            this.gbOperation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumOfQue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown3)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbQueLevel;
        private System.Windows.Forms.RadioButton rbMix;
        private System.Windows.Forms.RadioButton rbHard;
        private System.Windows.Forms.RadioButton rbMedium;
        private System.Windows.Forms.RadioButton rbEasy;
        private System.Windows.Forms.GroupBox gbQueType;
        private System.Windows.Forms.RadioButton rbTrueOrFalse;
        private System.Windows.Forms.RadioButton rbFillInTheBlanck;
        private System.Windows.Forms.RadioButton rbMultiChoice;
        private System.Windows.Forms.GroupBox gbOperation;
        private System.Windows.Forms.RadioButton rbDiv;
        private System.Windows.Forms.RadioButton rbMulti;
        private System.Windows.Forms.RadioButton rbSub;
        private System.Windows.Forms.RadioButton rbAdd;
        private System.Windows.Forms.RadioButton rbOpMix;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.NumericUpDown nudNumOfQue;
        private System.Windows.Forms.NumericUpDown numericUpDown3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmStart;
        private System.Windows.Forms.ToolStripMenuItem tsmExit;
    }
}

