namespace ChalengeApp
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeColectTwoScores_ShouldReturnCorrectResult()
        {
            //arrange
            var employeeSzymon = new Employee("Szymon", "Kowalik", "36");
            employeeSzymon.AddScore(9);
            employeeSzymon.AddScore(5);

            //act
            int result = employeeSzymon.Result;

            //assert
            Assert.AreEqual(14, result);
        }

        [Test]
        public void WhenEmployeeColectTwoNegativScorec_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new Employee("Szymon", "Kowalik", "36");
            employee.AddNegativeScore(5);
            employee.AddNegativeScore(7);

            //act
            int result = employee.Result;

            //assert
            Assert.AreEqual(-12, result);
        }

        [Test]
        public void WhenEmployeeColectScoresEqualZerro_ShouldReturnCorrectResult()
        {
            //arrange
            var employee = new Employee("Szymon", "Kowalik", "36");
            employee.AddScore(9);
            employee.AddScore(5);
            employee.AddScore(7);
            employee.AddScore(6);
            employee.AddNegativeScore(27);

            //act
            int result = employee.Result;

            //assert
            Assert.AreEqual(0, result);
        }
    }
}