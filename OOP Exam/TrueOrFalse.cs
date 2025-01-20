using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class TrueOrFalse : Question
    {
        public TrueOrFalse(string header, string body, int mark, Answers[] answersList, Answers correctAnswer) : base(header, body, mark, answersList, correctAnswer)
        {

        }
        public override void displayQuestions()
        {
            Console.WriteLine($"True Or False {Header}\n{Body}");
            for (int i = 0; i < AnswersList.Length; i++)
            {
                Console.WriteLine($"{i + 1}) {AnswersList[i].AnswerText}");
            }
        }
    }
}
