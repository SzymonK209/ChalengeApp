namespace ChalengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {

        private List<float> grades = new List<float>();

        public EmployeeInMemory(string name, string surname, string sex, int age, string jobPosition) 
            : base(name, surname, sex, age, jobPosition)
        {

        }

        public override void AddGrade(float grade)
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
        public override void AddGrade(char grade)
        {
            var gradeInput = grade switch
            {
                'A' or 'a' => 100,
                'B' or 'b' => 80,
                'C' or 'c' => 60,
                'D' or 'd' => 40,
                'E' or 'e' => 20,
                'F' or 'f' => 0,
                _ => throw new Exception("Incorrect Letter! \n"),
            };

            {
                this.AddGrade(gradeInput);
            }

        }
        public override void AddGrade(string grade)
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
                throw new Exception("String is not float! \n");
            }
        }
        public override void AddGrade(int grade)
        {
            float gradeInInt = (float)grade;
            this.AddGrade(gradeInInt);
        }
        public override void AddGrade(double grade)
        {
            float gradeInDouble = (float)grade;
            this.AddGrade(gradeInDouble);
        }
        public override Statistics GetStatistics()
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
