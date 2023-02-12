namespace ChalengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeColectGrades_ShouldReturnCorrectStatistics()
        {
            //arrange
            var employee = new Employee("Szymon", "Kowalik");
            employee.AddGrade(5);
            employee.AddGrade(79);
            employee.AddGrade(7.283);
            employee.AddGrade(42);
            employee.AddGrade(11f);
            employee.AddGrade('A');
            employee.AddGrade('b');
            employee.AddGrade('C');
            employee.AddGrade('d');
            employee.AddGrade('F');


            //act
            var statistics1 = employee.GetStatistics();
          

            //assert
            Assert.AreEqual(Math.Round(42.4, 1), Math.Round(statistics1.Average), 1);
            Assert.AreEqual(100, statistics1.Max);
            Assert.AreEqual(0, statistics1.Min);
            Assert.AreEqual('C', statistics1.AverageLetter);
        }
    }
}