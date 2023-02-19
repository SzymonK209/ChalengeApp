namespace ChalengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "gradesEmployee.txt";

        public EmployeeInFile(string name, string surname, string sex, int age, string jobPosition)
            : base(name, surname, sex, age, jobPosition)
        {

        }
        public override void AddGrade(float grade)
        {
            using (var writer = File.AppendText(fileName))
            {
                if (grade >= 0 && grade <= 100)
                {
                    writer.WriteLine(grade);
                }
                else
                {
                    throw new Exception("Invalid grade value! \n");
                }
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
                this.AddGrade(gradeInLeatters);
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
            var gradesFromFile = this.ReadGradesFromFile();
            var statistics = this.CountStatistics(gradesFromFile);
            return statistics;
        }
        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }
        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= grades.Count;

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
