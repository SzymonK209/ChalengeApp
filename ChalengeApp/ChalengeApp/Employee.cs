namespace ChalengeApp
{
    public class Employee
    {
        private List<float> grades = new List<float>();

        public Employee()
        {
            
        }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                Console.WriteLine("Invalid grade value");
            }
        }
        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;
                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;
                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;
                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;
                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;
                case 'F':
                case 'f':
                    this.grades.Add(0);
                    break;
                default:
                    Console.WriteLine("Wrong Letter");
                    break;
            }
        }
        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float gradeInString))
            {
                this.AddGrade(gradeInString);
            }
            else if (char.TryParse(grade, out char gradeInLeatters))
            {
                AddGrade(gradeInLeatters);
            }
            else
            {
                Console.WriteLine("String is not float");
            }
        }

        public void AddGrade(short grade)
        {
            float gradeInShort = (float)grade;
            this.AddGrade(gradeInShort);
        }
        public void AddGrade(int grade)
        {
            float gradeInInt = (float)grade;
            this.AddGrade(gradeInInt);
        }
        public void AddGrade(long grade)
        {
            float gradeInLong = (float)grade;
            this.AddGrade(gradeInLong);
        }
        public void AddGrade(double grade)
        {
            float gradeInDouble = (float)grade;
            this.AddGrade(gradeInDouble);
        }
        public void AddGrade(decimal grade)
        {
            var gradeInDecimal = (float)grade;
            this.AddGrade(gradeInDecimal);
        }
        

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;
            
            switch(statistics.Average)
            {
                case var average when average >= 81:
                    statistics.AverageLetter = 'A';
                    break;
                case var average when average >= 61:
                    statistics.AverageLetter = 'B';
                    break;
                case var average when average >= 41:
                    statistics.AverageLetter = 'C';
                    break;
                case var average when average >= 21:
                    statistics.AverageLetter = 'D';
                    break;
                case var average when average >= 1:
                    statistics.AverageLetter = 'E';
                    break;
                default:
                    statistics.AverageLetter = 'F';
                    break;
            }

            return statistics;
        }
    }
}
