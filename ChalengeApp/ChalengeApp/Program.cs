using ChalengeApp;

Employee employeeSzymon = new Employee("Szymon", "Kowalik", "36");
Employee employeeJan = new Employee("Jan", "Kowalski", "27");
Employee employeeJanusz = new Employee("Janusz", "Nowak", "53");

employeeSzymon.Addscore(9);
employeeSzymon.Addscore(5);
employeeSzymon.Addscore(7);
employeeSzymon.Addscore(6);
employeeSzymon.Addscore(10);

employeeJan.Addscore(9);
employeeJan.Addscore(5);
employeeJan.Addscore(7);
employeeJan.Addscore(6);
employeeJan.Addscore(3);

employeeJanusz.Addscore(1);
employeeJanusz.Addscore(2);
employeeJanusz.Addscore(3);
employeeJanusz.Addscore(4);
employeeJanusz.Addscore(5);

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
