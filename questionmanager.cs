using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Xml.Linq;

namespace TheQuiz
{
    public class questionmanager
    {
        public string[] GetQuestion(int questionNumber)
        {
            string stringQuestionNumber = questionNumber.ToString();
            string[] question = { "", "", "", "", "", "" };
            //Load the XML file
            XElement xmlQuestions = XElement.Load("questions.xml");

            //Question Title
            IEnumerable<XElement> QuestionTitle =
                from el in xmlQuestions.Elements("Question")
                where (string)el.Attribute("Number") == stringQuestionNumber
                from ed in el.Descendants("Title")
                select ed;
            foreach (XElement ed in QuestionTitle)
                question[0] = ed.Value;
            //Answer A
            IEnumerable<XElement> QuestionAnserA =
                from el in xmlQuestions.Elements("Question")
                where (string)el.Attribute("Number") == stringQuestionNumber
                from ed in el.Descendants("AnswerA")
                select ed;
            foreach (XElement ed in QuestionAnserA)
                question[1] = ed.Value;
            //Answer B
            IEnumerable<XElement> QuestionAnserB =
                from el in xmlQuestions.Elements("Question")
                where (string)el.Attribute("Number") == stringQuestionNumber
                from ed in el.Descendants("AnswerB")
                select ed;
            foreach (XElement ed in QuestionAnserB)
                question[2] = ed.Value;
            //Answer C
            IEnumerable<XElement> QuestionAnserC =
                from el in xmlQuestions.Elements("Question")
                where (string)el.Attribute("Number") == stringQuestionNumber
                from ed in el.Descendants("AnswerC")
                select ed;
            foreach (XElement ed in QuestionAnserC)
                question[3] = ed.Value;
            //Answer D
            IEnumerable<XElement> QuestionAnserD =
                from el in xmlQuestions.Elements("Question")
                where (string)el.Attribute("Number") == stringQuestionNumber
                from ed in el.Descendants("AnswerD")
                select ed;
            foreach (XElement ed in QuestionAnserD)
                question[4] = ed.Value;
            //Correct Answer
            IEnumerable<XElement> QuestionCorrectAnswer =
                from el in xmlQuestions.Elements("Question")
                where (string)el.Attribute("Number") == stringQuestionNumber
                from ed in el.Descendants("CorrectAnswer")
                select ed;
            foreach (XElement ed in QuestionCorrectAnswer)
                question[5] = ed.Value;

            return question;
        }
    } 
}