using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class PracticalExam : Exam
    {
        public PracticalExam(int time, int numOfQuestions, Question[] questions) : base(time, numOfQuestions, questions)
        {
            this.Time = time;
            this.NumOfQuestions = numOfQuestions;
            this.Questions = questions;

        }

        public override void DisplayExam()
        {
            int Answer;
            Console.WriteLine("Practical Exam");

            
            foreach (var question in Questions)
            {  
                question.displayQuestions();

                Console.WriteLine("Enter your answer Id:");
                if (int.TryParse(Console.ReadLine(), out Answer))
                {
                    
                    if (Answer == question.CorrectAnswer.AnswerId)
                    {
                        Console.WriteLine("Your answer is correct!");
                        Console.WriteLine($"{question.CorrectAnswer.AnswerText}");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer.");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input, please enter a number.");
                }

            }
        }

       
    }
}


