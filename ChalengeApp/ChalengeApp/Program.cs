using ChalengeApp;

var employee = new Employee("Szymon", "Kowalik");

employee.AddGrade(20f);
employee.AddGrade("10");
employee.AddGrade(7.8888888888888888888888888);
employee.AddGrade(63333);
employee.AddGrade(-71);

var statistics = employee.GetStatisticsWithForEach();

Console.WriteLine("\nStatistic with foreach");
Console.WriteLine($"\nEmployee {employee.Name} {employee.Surname} received the evaluation results:");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}\n");