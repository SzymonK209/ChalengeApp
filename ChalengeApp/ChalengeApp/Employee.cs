namespace ChalengeApp
{
    public class Employee
    {
        private List<int> score = new List<int>();
        
        public Employee(string name, string surname, string age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
        }
        public Employee(string name)
        {
            this.Name = name;
        }

        public string Name { get; private set; }
       
        public string Surname { get; private set; }
       
        public string Age { get; private set; }

        public int Result
        {
            get 
            {
                return this.score.Sum();
            }

        }
       
        public void AddScore(int score) 
        {
            this.score.Add(score);
        }
        
        public void AddNegativeScore(int number)
        { 
            this.score.Add(number * (-1)); 
        }
    }
}
