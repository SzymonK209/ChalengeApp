﻿namespace ChalengeApp
{
    public abstract class EmployeeBase : IEmployee
    {
        public EmployeeBase(string name, string surname, string sex, int age, string jobPosition)

        {
            this.Name = name;
            this.Surname = surname;
            this.Sex = sex;
            this.Age = age;
            this.JobPosition = jobPosition;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public string Sex { get; private set; }

        public int Age { get; private set; }

        public string JobPosition { get; private set; }

        public abstract void AddGrade(float grade);

        public abstract void AddGrade(char grade);

        public abstract void AddGrade(string grade);

        public abstract void AddGrade(int grade);

        public abstract void AddGrade(double grade);

        public abstract Statistics GetStatistics();
    }
}