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
        string[] currentQuestion = { "", "", "", "", "", "" };
        int intQuestionsCorrect = 0;
        int intQuestionsWrong = 0;
        int intQuestionsSkipped = 0;
        public QuizWindow()
        {
            InitializeComponent();
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
            Random rnd = new Random();
            questionmanager questionmanager = new questionmanager();
            //Finde heraus wie viele Fragen es gibt 
            XElement xmlQuestions = XElement.Load("questions.xml");
            string questionCountNum = "";
            var questionCountAtt =
                from ques1 in xmlQuestions.Elements("Count")
                select ques1;
            foreach (XElement ques1 in questionCountAtt)
                questionCountNum = ques1.Value;
            //Frage wird abgerufen
            int newQuestion = rnd.Next(1, Int32.Parse(questionCountNum) + 1);
            currentQuestion = questionmanager.GetQuestion(newQuestion);
            //Werte werden verteilt
            questionCurrentQuestion.Text = currentQuestion[0];
            questionAnswerA.Text = currentQuestion[1];
            questionAnswerB.Text = currentQuestion[2];
            questionAnswerC.Text = currentQuestion[3];
            questionAnswerD.Text = currentQuestion[4];
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
    }
}
