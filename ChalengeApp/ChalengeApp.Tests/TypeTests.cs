namespace ChalengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void GetTwoNumber_ShouldDifferentObject()
        {
            //arrange
            int number1 = 1;
            int number2 = 2;

            //act

            //assert
            Assert.AreNotEqual(number1, number2);
        }

        [Test]
        public void DifferentValueTypesAreEqual()
        {
            //arrange
            int number4 = 2;
            float number1 = 2;
            double number2 = 2;
            decimal number3 = 2;

            //act

            //assert
            Assert.AreEqual(number1, number2);
            Assert.AreEqual(number2, number3);
            Assert.AreEqual(number3, number4);
            Assert.AreEqual(number4, number1);
            Assert.AreEqual(number1, number3);
            Assert.AreEqual(number2, number4);
        }

        [Test]
        public void GetTwoName_ShouldDifferentObject()
        {
            //arange
            string name1 = "Szymon";
            string name2 = "Jan";

            //act

            //assert
            Assert.IsFalse(name1.Equals(name2));
            Assert.AreNotEqual(name1, name2);
        }

        [Test]
        public void GetNewEmployee_ShouldDifferentObject()
        {
            //arrange
            var employee1 = GetEmployee("Szymon");
            var employee2 = GetEmployee("Jan");
            var employee3 = employee2;

            //act

            //assert
            Assert.False(Object.ReferenceEquals(employee1, employee2));
            Assert.True(Object.ReferenceEquals(employee2, employee3));
            Assert.AreNotSame(employee1, employee2);
            Assert.AreSame(employee2, employee3);
            Assert.AreEqual(employee2, employee3);
            Assert.AreEqual("Szymon", employee1.Name);
            Assert.AreEqual(employee3.Name, employee2.Name);
        }
        [Test]
        public void WhenEmployeeColectScores_ShouldReturnCorrectResult()
        {
            //arrange
            var employee1 = GetEmployee("Szymon");

            employee1.AddScore(5);
            employee1.AddScore(5);
            employee1.AddNegativeScore(5);

            //act
            var result = employee1.Result;

            //assert
            Assert.AreEqual(5, result);


        }
        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }

    }
}
