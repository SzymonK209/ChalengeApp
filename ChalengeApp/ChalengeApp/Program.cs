using ChalengeApp;

var employee = new Employee("Szymon", "Kowalik");

employee.AddGrade(20);
employee.AddGrade("10");
employee.AddGrade(7.8888888888888888888888888);
employee.AddGrade(63333);
employee.AddGrade(-71);

var statistics = employee.GetStatistics();

Console.WriteLine($"Employee {employee.Name} {employee.Surname} received the evaluation results:");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");