using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Exam
{
    internal abstract class Exam
    {
        public int Time { get; set; }
        public int NumOfQuestions { get; set; }
        public Question[] Questions { get; set; }

        public Exam(int time, int numOfQuestions, Question[] questions)
        {
            Time = time;
            NumOfQuestions = numOfQuestions;
            Questions = questions;
        }

        public abstract void DisplayExam();
    }
}
