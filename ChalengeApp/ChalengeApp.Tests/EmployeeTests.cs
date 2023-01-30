namespace ChalengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void WhenEmployeeColectGrades_ShouldReturnCorrectStatistics()
        {
            //arrange
            var employee = new Employee("Szymon", "Kowalik");
            employee.AddGrades(8);
            employee.AddGrades(6);
            employee.AddGrades(7);
            employee.AddGrades(4);
            employee.AddGrades(10);

            //act
            var statistics1 = employee.GetStatistics();
          

            //assert
            Assert.AreEqual(7, statistics1.Average);
            Assert.AreEqual(10, statistics1.Max);
            Assert.AreEqual(4, statistics1.Min);
        }
    }
}