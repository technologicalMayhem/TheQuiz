using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;

namespace TheQuiz
{
    public partial class QuizWindow : Form
    {
        //Deklaration
        string[] currentQuestion = { "", "", "", "", "", "" };
        int intQuestionsCorrect = 0;
        int intQuestionsWrong = 0;
        int intQuestionsSkipped = 0;
        List<int> QuestionsAsked = new List<int>();
        Random rnd = new Random();
        //Einstiegspunkt
        public QuizWindow()
        {
            InitializeComponent();
            QuestionsAsked.Add(0);
            NewQuestion();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void buttonSkipQuestion_Click(object sender, EventArgs e)
        {
            intQuestionsSkipped++;
            questionCountSkipped.Text = "Fragen übersprungen: " + intQuestionsSkipped.ToString();
            NewQuestion();
        }
        void NewQuestion()
        {
            //Deklaration
            questionmanager questionmanager = new questionmanager();
            int newQuestion = 0;
            //Finde heraus wie viele Fragen es gibt 
            XElement xmlQuestions = XElement.Parse(Properties.Resources.questions);
            var questionCount = xmlQuestions.Elements("Question").Count();
            //Frage wird abgerufen und geprüft ob schon mal genutzt wurde. Wurden bereits alle benutzt so wird das Quiz beeendet
            while (true)
            {
                newQuestion = rnd.Next(1, questionCount + 1);

                if (!QuestionsAsked.Contains(newQuestion))
                {
                    QuestionsAsked.Add(newQuestion);
                    break;
                }
                if (QuestionsAsked.Count == questionCount + 1)
                {
                    EndQuiz();
                    return;
                }
            }
            currentQuestion = questionmanager.GetQuestion(newQuestion);
            //Werte werden verteilt
            questionCurrentQuestion.Text = currentQuestion[0];
            questionAnswerA.Text = currentQuestion[1];
            questionAnswerB.Text = currentQuestion[2];
            questionAnswerC.Text = currentQuestion[3];
            questionAnswerD.Text = currentQuestion[4];
        }
        int GetRandomQuestionNumber(int questionCount)
        {
            int intReturn = 0;
            intReturn = rnd.Next(1, questionCount + 1);
            return intReturn;
        }
        void GetResults(string correctAnswer)
        {
            if (currentQuestion[5] == correctAnswer)
            {
                intQuestionsCorrect++;
                questionCountCorrect.Text = "Fragen Richtig: " + intQuestionsCorrect.ToString();
            }
            else
            {
                intQuestionsWrong++;
                questionCountWrong.Text = "Fragen Falsch: " + intQuestionsWrong.ToString();
            }
            NewQuestion();
        }

        private void questionAnswerA_Click(object sender, EventArgs e)
        {
            GetResults("1");
        }

        private void questionAnswerB_Click(object sender, EventArgs e)
        {
            GetResults("2");
        }

        private void questionAnswerC_Click(object sender, EventArgs e)
        {
            GetResults("3");
        }

        private void questionAnswerD_Click(object sender, EventArgs e)
        {
            GetResults("4");
        }
        void EndQuiz()
        {
            Color redColor = Color.FromArgb(255, 0, 0);
            questionAnswerA.Hide();
            questionAnswerB.Hide();
            questionAnswerC.Hide();
            questionAnswerD.Hide();
            buttonSkipQuestion.Hide();
            questionCurrentQuestion.ForeColor = redColor;
            questionCurrentQuestion.Text = "Du hast alle Fragen beantwortet!";
        }
    }
}
