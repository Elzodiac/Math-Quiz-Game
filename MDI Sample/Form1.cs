using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MDI_Sample
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        stQuiz Quiz;
        public enum enQuestionsLevel { EasyLevel = 1, MedLevel = 2, HardLevel = 3, Mix = 4 };
        public enum enOperationType { Add = 1, Sub = 2, Mult = 3, Div = 4, MixOp = 5 };
        public enum enQuestionType { MultiChoice = 1, FillBlanck = 2, TrueOrFalse = 3};

        
        public struct stQuiz
        {
            public byte NumberOfQuestions;
            public enQuestionsLevel QuestionsLevel;
            public enQuestionType QuestionsType;
            public enOperationType OpType;
            public uint CountDown;

            public stQuiz()
            {
                NumberOfQuestions = 0;
                QuestionsLevel = default;
                QuestionsType = default;
                OpType = default;
                CountDown = 0;
            }
        }
 
        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.QuestionsLevel = ((enQuestionsLevel)1);
        }
        private void rbMedium_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.QuestionsLevel = ((enQuestionsLevel)2);
        }
        private void rbHard_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.QuestionsLevel = ((enQuestionsLevel)3);
        }
        private void rbMix_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.QuestionsLevel = ((enQuestionsLevel)4);
        }

        // Que Type:
        private void rbMultiChoice_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.QuestionsType = ((enQuestionType)1);
        }
        private void rbFillInTheBlanck_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.QuestionsType = ((enQuestionType)2);
        }
        private void rbTrueOrFalse_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.QuestionsType = ((enQuestionType)3);
        }

        // Operation:
        private void rbAdd_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.OpType = ((enOperationType)1);
        }
        private void rbSub_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.OpType = ((enOperationType)2);
        }
        private void rbMulti_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.OpType = ((enOperationType)3);
        }
        private void rbDiv_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.OpType = ((enOperationType)4);
        }
        private void rbOpMix_CheckedChanged(object sender, EventArgs e)
        {
            Quiz.OpType = ((enOperationType)5);
        }

        private void nudNumOfQue_ValueChanged(object sender, EventArgs e)
        {
            Quiz.NumberOfQuestions = ((byte)nudNumOfQue.Value);
        }

        public bool IsGroupBoxChecked(GroupBox groupBox)
        {
            return groupBox.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            if(IsGroupBoxChecked(gbQueLevel) && IsGroupBoxChecked(gbQueType) &&
                IsGroupBoxChecked(gbOperation) && nudNumOfQue.Value >= 1 &&
                numericUpDown3.Value >= 1)
            {
                
                switch (Quiz.QuestionsType)
                {
                    case enQuestionType.MultiChoice:                        
                        Form frm2 = new frmMathQuizMC(Quiz);
                        frm2.Show();
                        this.Hide();
                        break;
                    case enQuestionType.FillBlanck:
                        Form frm3 = new frmMathQuizFITB(Quiz);
                        frm3.Show();
                        this.Hide();
                        break;
                    case enQuestionType.TrueOrFalse:
                        Form frm4 = new frmMathQuizTOF(Quiz);
                        frm4.Show();
                        this.Hide();
                        break;
                }
            } else
            {
                MessageBox.Show("Please enter your choices to start the game", "Caption"
                    , MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            Quiz.CountDown = (byte)(numericUpDown3.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            rbEasy.Checked = true;
            rbMultiChoice.Checked = true;
            rbAdd.Checked = true;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            lbDate.Text = DateTime.Now.ToLongDateString();
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        private void tsmStart_Click(object sender, EventArgs e)
        {
            btnStart_Click(sender, e);
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }
    }
}
