using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static MDI_Sample.frmHome;

namespace MDI_Sample
{
    public partial class frmMathQuizFITB : Form
    {

        private stQuestion _Question2;

        private uint totalSeconds;
        private uint minutes;
        private uint seconds;

        stQuiz2 sQuiz2;

        public enum enQuestionsLevel { EasyLevel = 1, MedLevel = 2, HardLevel = 3, Mix = 4 };
        public enum enOperationType { Add = 1, Sub = 2, Mult = 3, Div = 4, MixOp = 5 };
        public enum enQuestionType { MultiChoice = 1, FillBlanck = 2, TrueOrFalse = 3 };
        public struct stQuiz2
        {
            public byte NumberOfQuestions;
            public enQuestionsLevel QuestionsLevel;
            public enQuestionType QuestionsType;
            public enOperationType OpType;
            public uint CountDown;

            public stQuiz2()
            {
                NumberOfQuestions = 0;
                QuestionsLevel = default;
                QuestionsType = default;
                OpType = default;
                CountDown = 0;
            }
        }


        public frmMathQuizFITB(stQuiz quiz)
        {
            InitializeComponent();
            sQuiz2.NumberOfQuestions = quiz.NumberOfQuestions;
            sQuiz2.QuestionsLevel = (enQuestionsLevel)quiz.QuestionsLevel;
            sQuiz2.QuestionsType = (enQuestionType)quiz.QuestionsType;
            sQuiz2.OpType = (enOperationType)quiz.OpType;
            sQuiz2.CountDown = quiz.CountDown;
        }

        public struct stQuestion
        {
            public double Number1;
            public double Number2;
            public enQuestionsLevel QuestionLevel;
            public enOperationType OperationType;
            public double CorrectAnswer;
            public double PlayerAnswer;
            public double NumberOfWrongAnswers;
            public double NumberOfRightAnswers;
            public bool isPass;
        }

        public void QuizStatus()
        {
            lbQuestionsNumber.Text = sQuiz2.NumberOfQuestions.ToString();
            lbQuestionLevel.Text = sQuiz2.QuestionsLevel.ToString();
            lbQuestionType.Text = sQuiz2.QuestionsType.ToString();
            lbOperation.Text = sQuiz2.OpType.ToString();
            lbCountDownTimer.Text = sQuiz2.CountDown.ToString();
        }

        public static byte RandomNumber(byte minValue, byte maxValue)
        {
            Random random = new Random();
            return (byte)random.Next(minValue, maxValue + 1);
        }
        public double SimpleCulc(double Num1, double Num2, enOperationType Operation, double Div)
        {
            switch (Operation)
            {
                case enOperationType.Add:
                    return Num1 + Num2;
                case enOperationType.Sub:
                    return Num1 - Num2;
                case enOperationType.Mult:
                    return Num1 * Num2;
                case enOperationType.Div:
                    return Div = Math.Round(Num1 / Num2, 2);
            }
            return 0;
        }
       
        public void GeneratQuetion()
        {
            if (sQuiz2.QuestionsLevel == enQuestionsLevel.Mix)
                _Question2.QuestionLevel = (enQuestionsLevel)RandomNumber(1, 3);
            else
                _Question2.QuestionLevel = sQuiz2.QuestionsLevel;


            if (sQuiz2.OpType == enOperationType.MixOp)
                _Question2.OperationType = (enOperationType)RandomNumber(1, 3);
            else
                _Question2.OperationType = sQuiz2.OpType;

            Random rand = new Random();


            switch (_Question2.QuestionLevel)
            {
                case enQuestionsLevel.EasyLevel:
                    _Question2.Number1 = rand.Next(1, 49);
                    _Question2.Number2 = rand.Next(1, 49);
                    _Question2.CorrectAnswer = SimpleCulc(_Question2.Number1, _Question2.Number2, _Question2.OperationType, _Question2.Number1 / _Question2.Number2);
                    break;
                case enQuestionsLevel.MedLevel:
                    _Question2.Number1 = rand.Next(50, 99);
                    _Question2.Number2 = rand.Next(50, 99);
                    _Question2.CorrectAnswer = SimpleCulc(_Question2.Number1, _Question2.Number2, _Question2.OperationType, _Question2.Number1 / _Question2.Number2);
                    break;
                case enQuestionsLevel.HardLevel:
                    _Question2.Number1 = rand.Next(100, 150);
                    _Question2.Number2 = rand.Next(100, 150);
                    _Question2.CorrectAnswer = SimpleCulc(_Question2.Number1, _Question2.Number2, _Question2.OperationType, _Question2.Number1 / _Question2.Number2);
                    break;
            }


            if (_Question2.OperationType == enOperationType.Add)
                lbOper.Text = _Question2.Number1.ToString() + " + " + _Question2.Number2.ToString();
            else if (_Question2.OperationType == enOperationType.Sub)
                lbOper.Text = _Question2.Number1.ToString() + " - " + _Question2.Number2.ToString();
            else if (_Question2.OperationType == enOperationType.Mult)
                lbOper.Text = _Question2.Number1.ToString() + " * " + _Question2.Number2.ToString();
            else
                lbOper.Text = _Question2.Number1.ToString() + " / " + _Question2.Number2.ToString();

            

            CountDownTimer();
        }


        public bool CheckTheAnswer()
        {
            if (_Question2.CorrectAnswer == _Question2.PlayerAnswer)
            {
                if (MessageBox.Show("Right Answer!", "Result", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    btnNext.Enabled = true;
                    tsmNext.Enabled = true;
                    btnCheck.Enabled = false;
                    _Question2.NumberOfRightAnswers++;
                }
            }
            else if (MessageBox.Show("Wrong Answer!\n Right Answer is: " +
                    _Question2.CorrectAnswer.ToString(), "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                btnNext.Enabled = true;
                tsmNext.Enabled = true;
                btnCheck.Enabled = false;
                _Question2.NumberOfWrongAnswers++;
            }
            return true;
        }
        public void GameResultScreen()
        {

            lbOper.Visible = false;
            lbOper.Visible = false;
            btnCheck.Visible = false;
            tbAnswer.Visible = false;
            timer3.Stop();


            if (MathGameResult())
            {
                lbResult.Text = "Pass";
                this.BackColor = Color.Green;
            }
            else
            {
                this.BackColor = Color.Red;
                lbResult.Text = "Fail";
            }
        }
        public bool MathGameResult()
        {
            if (_Question2.NumberOfRightAnswers >= _Question2.NumberOfWrongAnswers)
                return true;
            else
                return false;
        }
        public void GameOver()
        {
            GameResultScreen();
            MathGameResult();
        }
        public void PlayMathGame()
        {
            GeneratQuetion();
            QuizStatus();
        }
   
        public void CountDownTimer()
        {
            totalSeconds = sQuiz2.CountDown * 60;
            UpdateTime();
            timer3.Start();
        }
        public void UpdateTime()
        {
            minutes = totalSeconds / 60;
            if (totalSeconds >= 60)
                seconds = totalSeconds - ((totalSeconds / 60) * 60);
            else
                seconds = totalSeconds;

            lbCountDownTimer.Text = $"{minutes:D2}:{seconds:D2}";
        }
        private void timer3_Tick_1(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                UpdateTime();
            }
            else if (totalSeconds == 0)
            {
                timer3.Stop();
                if (MessageBox.Show("Time Finished", "Timer", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    btnCheck.Enabled = false;
                    btnNext.Enabled = true;
                }
            }
        }

        public double PercOfWin(double QuesCount)
        {
            return ((_Question2.NumberOfRightAnswers / QuesCount) * 100);
        }

        public double QuesCounter = 0;

        private byte Counter = 0;

        private void frmMathQuizFITB_Load(object sender, EventArgs e)
        {
            timer3.Enabled = false;
            tsmNext.Enabled = false;
        }

        private void btnStart_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Game Started", "Start", MessageBoxButtons.OK,
               MessageBoxIcon.Information) == DialogResult.OK)
            {
                tbAnswer.Focus();
                timer3.Enabled = true;
                btnStart.Enabled = false;
                btnNext.Enabled = false;
                btnCheck.Enabled = true;
                tsmStart.Enabled = false;
                tsmNext.Enabled = false;
                PlayMathGame();
            }
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Exit",
               MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)
               == DialogResult.Yes)
            {
                Form frm1 = new frmHome();
                frm1.Show();
                this.Hide();
            }
        }

        private void btnNext_Click_1(object sender, EventArgs e)
        {
            
            btnNext.Enabled = false;
            tsmNext.Enabled = false;
            btnCheck.Enabled = true;
            tbAnswer.Text = string.Empty;

            Counter++;

            if (Counter < sQuiz2.NumberOfQuestions)
                GeneratQuetion();
            else
                GameOver();
        }

        private void btnCheck_Click_1(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(tbAnswer.Text))
            {
                

                MessageBox.Show("The field cannot be empty or contain only spaces", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                tbAnswer.Focus();
            }
            else
            {
                _Question2.PlayerAnswer = Convert.ToDouble(tbAnswer.Text);

                btnNext.Enabled = false;
                btnCheck.Enabled = false;

                CheckTheAnswer();
                QuesCounter++;
                double Result = PercOfWin(QuesCounter);
                Result = Math.Round(Result, 2);
                lbPercentage.Text = Result.ToString() + " %";
            }
        }

        private void tsmStart_Click(object sender, EventArgs e)
        {
            btnStart_Click_1(sender, e);
        }

        private void tsmNext_Click(object sender, EventArgs e)
        {
            btnNext_Click_1(sender, e);
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            btnExit_Click_1(sender, e);
        }

        private void tsmClear_Click(object sender, EventArgs e)
        {
            tbAnswer.Clear();
        }

        private string CopyText;
        private string CutText;
        private void tsmCopy_Click(object sender, EventArgs e)
        {
            CopyText = tbAnswer.Text;
        }

        private void tsmPaste_Click(object sender, EventArgs e)
        {
            if(CopyText != null)
            {
                tbAnswer.Text = tbAnswer.Text + CopyText;

            }

            if(CutText != null)
            {
                tbAnswer.Text = CutText;
                CutText = null;
            }
        }

        private void tsmCut_Click(object sender, EventArgs e)
        {
            CopyText = null;
            CutText = tbAnswer.Text;
            tbAnswer.Clear();
        }

        private void tbAnswer_TextChanged(object sender, EventArgs e)
        {
            tbAnswer.SelectionStart = tbAnswer.Text.Length;
        }
    }
}
