using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MDI_Sample.frmHome;

namespace MDI_Sample
{
    public partial class frmMathQuizMC : Form
    {
        
        private stQuestion _Question;

        private uint totalSeconds;
        private uint minutes;
        private uint seconds;

        stQuiz2 sQuiz;

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


        public frmMathQuizMC(stQuiz quiz)
        {
            InitializeComponent();
            sQuiz.NumberOfQuestions = quiz.NumberOfQuestions;
            sQuiz.QuestionsLevel = (enQuestionsLevel)quiz.QuestionsLevel;
            sQuiz.QuestionsType = (enQuestionType)quiz.QuestionsType;
            sQuiz.OpType = (enOperationType)quiz.OpType;
            sQuiz.CountDown = quiz.CountDown;
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
            lbQuestionsNumber.Text = sQuiz.NumberOfQuestions.ToString();
            lbQuestionLevel.Text = sQuiz.QuestionsLevel.ToString();
            lbQuestionType.Text = sQuiz.QuestionsType.ToString();
            lbOperation.Text = sQuiz.OpType.ToString();
            lbCountDownTimer.Text = sQuiz.CountDown.ToString();
        }

        public static byte RandomNumber(byte minValue, byte maxValue)
            {
                 Random random = new Random();
                return (byte)random.Next(minValue, maxValue + 1);
            }
        public double SimpleCulc(double Num1, double Num2, enOperationType Operation, double Div)
        {
            switch(Operation)
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
        public void GetRandomSelections(double CorrectAnswer)
        {
            RadioButton[] radioButtons;
            radioButtons = new RadioButton[] { rbOpt1, rbOpt2, rbOpt3, rbOpt4 };

            Random random;
            random = new Random();


            int correctIndex = random.Next(radioButtons.Length);

            for (int i = 0; i < radioButtons.Length; i++)
            {
                if (i == correctIndex)
                {
                    radioButtons[i].Text = CorrectAnswer.ToString();
                }
                else
                {
                    double randomNum = 0;

                    do
                    {
                        if (_Question.OperationType == enOperationType.Div)
                        {
                            randomNum = ((random.NextDouble() * ((_Question.CorrectAnswer - 0.10) - (_Question.CorrectAnswer + 0.50))) + _Question.CorrectAnswer + 0.50);
                            randomNum = Math.Round(randomNum, 2);
                        }
                        else
                        {
                            if (_Question.OperationType == enOperationType.Sub) 

                                randomNum = random.Next((int)(_Question.CorrectAnswer - 10), (int)(_Question.CorrectAnswer + 10));

                            else
                            {
                                do
                                    randomNum = random.Next((int)(_Question.CorrectAnswer - 5), (int)(_Question.CorrectAnswer + 10));

                                while (randomNum <= 0);
                            }
                        }
                           
                    }
                    while (randomNum == CorrectAnswer);

                    radioButtons[i].Text = randomNum.ToString();
                }
            }
        }
        public void GeneratQuetion()
        {
            if(sQuiz.QuestionsLevel == enQuestionsLevel.Mix) 
                _Question.QuestionLevel = (enQuestionsLevel)RandomNumber(1, 3);           
            else
                _Question.QuestionLevel = sQuiz.QuestionsLevel;


             if(sQuiz.OpType == enOperationType.MixOp)        
                _Question.OperationType = (enOperationType)RandomNumber(1, 3);        
             else           
                _Question.OperationType = sQuiz.OpType;

            Random rand = new Random();


            switch (_Question.QuestionLevel)
            {
                case enQuestionsLevel.EasyLevel:
                    _Question.Number1 = rand.Next(1, 49); 
                    _Question.Number2 = rand.Next(1, 49);
                    _Question.CorrectAnswer = SimpleCulc(_Question.Number1, _Question.Number2, _Question.OperationType, _Question.Number1 / _Question.Number2);
                    break;
                case enQuestionsLevel.MedLevel:
                    _Question.Number1 = rand.Next(50, 99);
                    _Question.Number2 = rand.Next(50, 99);
                    _Question.CorrectAnswer = SimpleCulc(_Question.Number1, _Question.Number2, _Question.OperationType, _Question.Number1 / _Question.Number2);
                    break;
                case enQuestionsLevel.HardLevel:
                    _Question.Number1 = rand.Next(100, 150);
                    _Question.Number2 = rand.Next(100, 150);
                    _Question.CorrectAnswer = SimpleCulc(_Question.Number1, _Question.Number2, _Question.OperationType, _Question.Number1 / _Question.Number2);
                    break;
            }


            if (_Question.OperationType == enOperationType.Add)
                lbOper.Text = _Question.Number1.ToString() + " + " + _Question.Number2.ToString();
            else if (_Question.OperationType == enOperationType.Sub)
                lbOper.Text = _Question.Number1.ToString() + " - " + _Question.Number2.ToString();
            else if (_Question.OperationType == enOperationType.Mult)
                lbOper.Text = _Question.Number1.ToString() + " * " + _Question.Number2.ToString();
            else
                lbOper.Text = _Question.Number1.ToString() + " / " + _Question.Number2.ToString();

            GetRandomSelections(_Question.CorrectAnswer);

            CountDownTimer();
        }


        public bool CheckTheAnswer()
        {
            if (_Question.CorrectAnswer == _Question.PlayerAnswer)
            {
                if (MessageBox.Show("Right Answer!", "Result", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    btnNext.Enabled = true;
                    tsmNext.Enabled = true;
                    btnCheck.Enabled = false;
                    _Question.NumberOfRightAnswers++;
                }
            }
            else if (MessageBox.Show("Wrong Answer!\n Right Answer is: " +
                    _Question.CorrectAnswer.ToString(), "Result",
                    MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
            {
                btnNext.Enabled = true;
                tsmNext.Enabled = true;
                btnCheck.Enabled = false;
                _Question.NumberOfWrongAnswers++; 
            }
            return true;
        }
        public void GameResultScreen()
        {

            pnlAnswer.Visible = false;
            label8.Visible = false;
            lbOper.Visible = false;
            btnCheck.Visible = false;
            timer2.Stop();


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
            if (_Question.NumberOfRightAnswers >= _Question.NumberOfWrongAnswers)
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
        private void btnStart_Click(object sender, EventArgs e)
        { 

            if (MessageBox.Show("Game Started", "Start", MessageBoxButtons.OK,
                MessageBoxIcon.Information) == DialogResult.OK )
            {
                timer2.Enabled = true;
                btnStart.Enabled = false;
                btnNext.Enabled = false;
                btnCheck.Enabled = true;
                tsmStart.Enabled = false;
                tsmNext.Enabled = false;
                PlayMathGame();
            }
        }

        private void rbOpt1_CheckedChanged(object sender, EventArgs e)
        {
            _Question.PlayerAnswer = Convert.ToDouble(rbOpt1.Text);
        }
        private void rbOpt2_CheckedChanged(object sender, EventArgs e)
        {
            _Question.PlayerAnswer = Convert.ToDouble(rbOpt2.Text);
        }
        private void rbOpt3_CheckedChanged(object sender, EventArgs e)
        {
            _Question.PlayerAnswer = Convert.ToDouble(rbOpt3.Text);
        }
        private void rbOpt4_CheckedChanged(object sender, EventArgs e)
        {
            _Question.PlayerAnswer = Convert.ToDouble(rbOpt4.Text);
        }


        public void CountDownTimer()
        {
            totalSeconds = sQuiz.CountDown * 60;
            UpdateTime();
            timer2.Start();
        }
        public void UpdateTime()
        {
            minutes = totalSeconds / 60;
            if(totalSeconds >= 60)           
                seconds = totalSeconds - ((totalSeconds / 60) * 60);
            else          
                seconds =  totalSeconds;           
            
            lbCountDownTimer.Text = $"{minutes:D2}:{seconds:D2}";
        }
        private void timer2_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                UpdateTime();
            }
            else if (totalSeconds == 0)
            {
                timer2.Stop();
                if(MessageBox.Show("Time Finished", "Timer", MessageBoxButtons.OK,
                    MessageBoxIcon.Information) == DialogResult.OK)
                {
                    btnCheck.Enabled = false;
                    btnNext.Enabled = true;
                }
            }
        }

        public double PercOfWin(double QuesCount)
        {
            return ((_Question.NumberOfRightAnswers / QuesCount) * 100);
        }

        public double QuesCounter = 0;
        public bool IsPanelChecked(Panel panel)
        {
            return panel.Controls.OfType<RadioButton>().Any(rb => rb.Checked);
        }
        private void btnCheck_Click(object sender, EventArgs e)
        {
            if(IsPanelChecked(pnlAnswer))
            {
                //btnNext.Enabled = false;
                btnCheck.Enabled = false;


                CheckTheAnswer();
                QuesCounter++;
                double Result = PercOfWin(QuesCounter);
                Result = Math.Round(Result, 2);
                lbPercentage.Text = Result.ToString() + " %";
            }
            else          
                MessageBox.Show("Please choose an answer", "Choose an answer"
                    , MessageBoxButtons.OK,MessageBoxIcon.Information);    
        }

        private byte Counter = 0;

        private void btnNext_Click(object sender, EventArgs e)
        {
            rbOpt1.Checked = false;
            rbOpt2.Checked = false;
            rbOpt3.Checked = false;
            rbOpt4.Checked = false;

            btnNext.Enabled = false;
            tsmNext.Enabled = false;
            btnCheck.Enabled = true;

            Counter++;

            if (Counter < sQuiz.NumberOfQuestions)
                GeneratQuetion();
            else         
                GameOver();          
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Form frm1 = new frmHome();
                frm1.Show();
                this.Hide();
            }
            
        }

        private void frmMathQuizMC_Load(object sender, EventArgs e)
        {
            timer2.Enabled = false;
            tsmNext.Enabled = false;
        }

        private void tsmStart_Click(object sender, EventArgs e)
        {
            btnStart_Click(sender, e);
        }

        private void tsmNext_Click(object sender, EventArgs e)
        {
            btnNext_Click(sender, e);
        }

        private void tsmExit_Click(object sender, EventArgs e)
        {
            btnExit_Click(sender, e);
        }
    }
}
