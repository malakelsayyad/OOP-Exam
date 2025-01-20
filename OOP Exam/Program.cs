using System.Runtime.InteropServices;

namespace OOP_Exam
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Subject subject = new Subject(1, "Math");

            int examType, examTime, numOfQuestions;

            Console.WriteLine("Enter Exam type (1 - Practical | 2 - Final):");
            while (!int.TryParse(Console.ReadLine(), out examType) || (examType != 1 && examType != 2))
            {
                Console.WriteLine("Invalid input. Enter 1 for Practical or 2 for Final:");
            }

            Console.WriteLine("Enter Exam Time (in minutes):");
            while (!int.TryParse(Console.ReadLine(), out examTime) || examTime <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number:");
            }

            Console.WriteLine("Enter Number of Questions:");
            while (!int.TryParse(Console.ReadLine(), out numOfQuestions) || numOfQuestions <= 0)
            {
                Console.WriteLine("Invalid input. Enter a positive number:");
            }

            Question[] questions = new Question[numOfQuestions];

            for (int i = 0; i < numOfQuestions; i++)
            {
                if (examType == 1)
                {
                    Console.WriteLine("MCQ :");
                    Console.WriteLine("Enter Question Body:");
                    string body = Console.ReadLine();

                    int mark;
                    Console.WriteLine("Enter Question Mark:");
                    while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
                    {
                        Console.WriteLine("Invalid input. Enter a positive number:");
                    }

                    int numOfOptions;
                    Console.WriteLine("Enter Number of Options:");
                    while (!int.TryParse(Console.ReadLine(), out numOfOptions) || numOfOptions < 2)
                    {
                        Console.WriteLine("Invalid input. There should be at least 2 options:");
                    }

                    Answers[] answers = new Answers[numOfOptions];
                    for (int j = 0; j < numOfOptions; j++)
                    {
                        Console.WriteLine($"Enter Option {j + 1}:");
                        answers[j] = new Answers(j + 1, Console.ReadLine());
                    }

                    int correctAnswerId;
                    Console.WriteLine("Enter Correct Answer Option Number:");
                    while (!int.TryParse(Console.ReadLine(), out correctAnswerId) || correctAnswerId <= 0 || correctAnswerId > numOfOptions)
                    {
                        Console.WriteLine("Invalid input. Enter a valid option number:");
                    }

                    questions[i] = new MCQ("MCQ", body, mark, answers, answers[correctAnswerId - 1]);
                }
                else if (examType == 2)
                {
                    int typeOfQuestion;
                    Console.WriteLine($"Enter Type of Question {i + 1} (1 - MCQ | 2 - True/False):");
                    while (!int.TryParse(Console.ReadLine(), out typeOfQuestion) || (typeOfQuestion != 1 && typeOfQuestion != 2))
                    {
                        Console.WriteLine("Invalid input. Enter 1 for MCQ or 2 for True/False:");
                    }

                    Console.WriteLine("Enter Question Body:");
                    string body = Console.ReadLine();

                    int mark;
                    Console.WriteLine("Enter Question Mark:");
                    while (!int.TryParse(Console.ReadLine(), out mark) || mark <= 0)
                    {
                        Console.WriteLine("Invalid input. Enter a positive number:");
                    }

                    if (typeOfQuestion == 1)
                    {
                        int numOfOptions;
                        Console.WriteLine("Enter Number of Options:");
                        while (!int.TryParse(Console.ReadLine(), out numOfOptions) || numOfOptions < 2)
                        {
                            Console.WriteLine("Invalid input. There should be at least 2 options:");
                        }
                         
                        Answers[] answers = new Answers[numOfOptions];
                        for (int j = 0; j < numOfOptions; j++)
                        {
                            Console.WriteLine($"Enter Option {j + 1}:");
                            answers[j] = new Answers(j + 1, Console.ReadLine());
                        }

                        int correctAnswerId;
                        Console.WriteLine("Enter Correct Answer Option Number:");
                        while (!int.TryParse(Console.ReadLine(), out correctAnswerId) || correctAnswerId <= 0 || correctAnswerId > numOfOptions)
                        {
                            Console.WriteLine("Invalid input. Enter a valid option number:");
                        }

                        questions[i] = new MCQ("MCQ", body, mark, answers, answers[correctAnswerId - 1]);
                    }
                    else
                    {
                        Answers[] answers = {
                            new Answers(1, "True"),
                            new Answers(2, "False")
                        };

                        int correctAnswerId;
                        Console.WriteLine("Enter Correct Answer (1 for True, 2 for False):");
                        while (!int.TryParse(Console.ReadLine(), out correctAnswerId) || (correctAnswerId != 1 && correctAnswerId != 2))
                        {
                            Console.WriteLine("Invalid input. Enter 1 for True or 2 for False:");
                        }

                        questions[i] = new TrueOrFalse("True|False", body, mark, answers, answers[correctAnswerId - 1]);
                    }
                }
            }

            Exam exam;
            if (examType == 1)
            {
                exam = new PracticalExam(examTime, numOfQuestions, questions);
            }
            else
            {
                exam = new FinalExam(examTime, numOfQuestions, questions);
            }

            Console.WriteLine("--------------------------------------");
            exam.DisplayExam();
        }
    }
}

