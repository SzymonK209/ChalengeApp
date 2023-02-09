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
            employee.AddGrade(6);
            employee.AddGrade(7);
            employee.AddGrade(4);
            employee.AddGrade(10);

            //act
            var statistics1 = employee.GetStatisticsWithFor();
          

            //assert
            Assert.AreEqual(Math.Round(6.40, 2), Math.Round(statistics1.Average), 2);
            Assert.AreEqual(10, statistics1.Max);
            Assert.AreEqual(4, statistics1.Min);
        }
    }
}