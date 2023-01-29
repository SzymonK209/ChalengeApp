using ChalengeApp;

Employee employeeSzymon = new Employee("Szymon", "Kowalik", "36");
Employee employeeJan = new Employee("Jan", "Kowalski", "27");
Employee employeeJanusz = new Employee("Janusz", "Nowak", "53");

employeeSzymon.AddScore(9);
employeeSzymon.AddScore(5);
employeeSzymon.AddScore(7);
employeeSzymon.AddScore(6);
employeeSzymon.AddNegativeScore(27);

employeeJan.AddScore(9);
employeeJan.AddScore(5);
employeeJan.AddScore(7);
employeeJan.AddScore(6);
employeeJan.AddScore(3);

employeeJanusz.AddScore(5);
employeeJanusz.AddScore(9);
employeeJanusz.AddNegativeScore(3);
employeeJanusz.AddScore(10);
employeeJanusz.AddScore(9);

List<Employee> employees = new List<Employee>()
{
   employeeSzymon, employeeJan, employeeJanusz
};

int maxResult = -1;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
    }
}
Console.WriteLine($"The highest number of points: {maxResult} reached by the employee \n");

foreach (var employe in employees)
{
    if (employe.Result >= maxResult)
    {
        Console.WriteLine($"{employe.Name} {employe.Surname} age {employe.Age}");
    }

}
