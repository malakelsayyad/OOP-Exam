using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public int Mark { get; set; }

        public Answers[] AnswersList { get; set; }

        public Answers CorrectAnswer { get; set; }

        public Question(string header, string body, int mark, Answers[] answersList, Answers correctAnswer)
        { 
            Header = header;
            Body = body;
            Mark = mark;
            AnswersList = answersList;
            CorrectAnswer = correctAnswer;
        }

        public abstract void displayQuestions(); 

    }
}
