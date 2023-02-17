namespace ChalengeApp
{
    public interface IEmployee
    {
        string Name { get; }

        string Surname { get; }

        string Sex { get; }

        int Age { get; }

        string JobPosition { get; }

        void AddGrade(float grade);

        void AddGrade(char grade);

        void AddGrade(string grade);

        void AddGrade(short grade);

        void AddGrade(int grade);

        void AddGrade(long grade);

        void AddGrade(double grade);

        void AddGrade(decimal grade);

        Statistics GetStatistics();

    }
}
