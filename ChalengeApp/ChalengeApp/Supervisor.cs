namespace ChalengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname, string sex, int age, string jobPosition)

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


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Invalid grade value! \n");
            }
        }
 
        public void AddGrade(string grade)
        {
            var gradeInput = grade switch
            {
                "6" => 100,
                "-6" or "6-" => 95,
                "5" => 80,
                "+5" or "5+" => 85,
                "-5" or "5-" => 75,
                "4" => 60,
                "+4" or "4+" => 65,
                "-4" or "4-" => 55,
                "3" => 40,
                "+3" or "3+" => 45,
                "-3" or "3-" => 35,
                "2" => 20,
                "+2" or "2+" => 25,
                "-2" or "2-" => 15,
                "1" => 0,
                _ => throw new Exception("Wrong assessment! \n"),
            };

            {
                this.AddGrade(gradeInput);
            }

        }
        public void AddGrade(char grade)
        {
            throw new NotImplementedException();
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

            switch (statistics.Average)
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
