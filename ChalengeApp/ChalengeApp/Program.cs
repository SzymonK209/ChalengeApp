using ChalengeApp;

var employee = new Employee("Szymon", "Kowalik");

employee.AddGrades(79);
employee.AddGrades(58);
employee.AddGrades(97);
employee.AddGrades(63);
employee.AddGrades(71);

var statistics = employee.GetStatistics();

Console.WriteLine($"Employee {employee.Name} {employee.Surname} received the evaluation results:");
Console.WriteLine($"Average : {statistics.Average}");
Console.WriteLine($"Max: {statistics.Max}");
Console.WriteLine($"Min: {statistics.Min}");