using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numOfQuestions, Question[] questions) : base(time, numOfQuestions, questions)
        {
            this.Time = time;
            this.NumOfQuestions = numOfQuestions;
            this.Questions = questions;
        }

        public override void DisplayExam()
        {
            int Answer;
            int totalScore = 0;
            int totalMarks = 0;

            Console.WriteLine("Practical Exam");
         
            foreach (Question question in Questions)
            {
              
                totalMarks += question.Mark;
                question.displayQuestions();

       
                Console.WriteLine("Enter your answer Id:");
                if (int.TryParse(Console.ReadLine(), out Answer))
                {
                   
                    if (Answer == question.CorrectAnswer.AnswerId)
                    {
                        Console.WriteLine("Your answer is correct!");
                        totalScore+= question.Mark; 
                    }
                    else
                    {
                        Console.WriteLine("Wrong Answer.");
                    }

                    
                    Console.WriteLine($"Correct answer is: {question.CorrectAnswer.AnswerText}");
                }
                else
                {
                 
                    Console.WriteLine("Invalid input, please enter a number.");
                }
            }
            Console.WriteLine($"\nYour total marks: {totalScore} out of {totalMarks}");
        }
    }
}
