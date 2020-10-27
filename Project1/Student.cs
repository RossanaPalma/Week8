using System;
using System.Collections.Generic;
using System.Text;

namespace Project1
{
    class Student
    {
        private double _quizze1;
        private double _quizze2;
        private double _quizze3;
        private double _midtermExam;
        private double _finalExam;
        private double grade;


        public Student(double quizze1, double quizze2, double quizze3,
                     double midtermExam, double finalExam)
        {
            this.MidtermExam = midtermExam;
            this.FinalExam = finalExam;
            this.Quizze1 = quizze1;
            this.Quizze2 = quizze2;
            this.Quizze3 = quizze3;
        }

        public double Quizze1
        {
            get { return _quizze1; }
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("The grade is between 0 and 10.");
                }
                _quizze1 = value;
            }
        }
        public double Quizze2
        {
            get
            {
                return _quizze2;
            }
            set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("The grade is between 0 and 10.");
                }
                _quizze2 = value;
            }
        }

        public double Quizze3
        {
            get { return _quizze3; }
            private set
            {
                if (value < 0 || value > 10)
                {
                    throw new ArgumentOutOfRangeException("The grade is between 0 and 10.");
                }
                _quizze3 = value;
            }
        }
        public double MidtermExam
        {
            get { return _midtermExam; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The grade is between 0 and 100.");
                }
                _midtermExam = value;
            }
        }
        public double FinalExam
        {
            get { return _finalExam; }
            set
            {
                if (value < 0 || value > 100)
                {
                    throw new ArgumentOutOfRangeException("The grade is between 0 and 100.");
                }
                _finalExam = value;
            }
        }

        public double FinalGrade()
        {
            double quizzesGrades = (Quizze1 * 0.25) +
                                        (Quizze2 * 0.25) +
                                        (Quizze3 * 0.25);

            MidtermExam = (MidtermExam * 0.35);

            FinalExam = (FinalExam * 0.4);

            grade = quizzesGrades + MidtermExam + FinalExam;
            return grade;
        }
    }
}





   

