using ChalengeApp;

Employee employee1 = new Employee("Szymon", "Kowalik", "36");
Employee employee2 = new Employee("Jan", "Kowalski", "27");
Employee employee3 = new Employee("Janusz", "Nowak", "53");

employee1.Addscore(9);
employee1.Addscore(5);
employee1.Addscore(7);
employee1.Addscore(6);
employee1.Addscore(10);

employee2.Addscore(5);
employee2.Addscore(2);
employee2.Addscore(3);
employee2.Addscore(8);
employee2.Addscore(4);

employee3.Addscore(7);
employee3.Addscore(5);
employee3.Addscore(4);
employee3.Addscore(1);
employee3.Addscore(9);

List<Employee> employees = new List<Employee>()
{
   employee1, employee2, employee3
};

int maxResult = 0;
Employee employeeWithMaxResult = null;

foreach (var employee in employees)
{
    if (employee1.Result > maxResult)
    {
        employeeWithMaxResult = employee1;
        maxResult = employee1.Result;
    }
    else if (employee2.Result > maxResult)
    {
        employeeWithMaxResult = employee2;
        maxResult = employee1.Result;
    }
    else if (employee3.Result > maxResult)
    {
        employeeWithMaxResult = employee3;
        maxResult = employee1.Result;
    }

}

Console.WriteLine($"Pracownik z najwyższą sumą ocen: {maxResult} pkt \n{employeeWithMaxResult.Name} {employeeWithMaxResult.Surname} lat {employeeWithMaxResult.Age}");