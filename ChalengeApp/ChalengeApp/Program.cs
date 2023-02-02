using ChalengeApp;

var employee = new Employee("Szymon", "Kowalik");

employee.AddGrade(20f);
employee.AddGrade("10");
employee.AddGrade(7.8888888888888888888888888);
employee.AddGrade(63333);
employee.AddGrade(-71);

var statisticsFroEach = employee.GetStatisticsWithForEach();

Console.WriteLine("\nStatistic with foreach");
Console.WriteLine($"\nEmployee {employee.Name} {employee.Surname} received the evaluation results:");
Console.WriteLine($"Average : {statisticsFroEach.Average:N2}");
Console.WriteLine($"Max: {statisticsFroEach.Max}");
Console.WriteLine($"Min: {statisticsFroEach.Min}\n");

var statistics2 = employee.GetStatisticsWithFor();

Console.WriteLine("\nStatistic with for");
Console.WriteLine($"\nEmployee {employee.Name} {employee.Surname} received the evaluation results:");
Console.WriteLine($"Average : {statistics2.Average:N2}");
Console.WriteLine($"Max: {statistics2.Max}");
Console.WriteLine($"Min: {statistics2.Min}\n");

var statisticsDoWhile = employee.GetStatisticsWithDoWhile();

Console.WriteLine("\nStatistic with do while");
Console.WriteLine($"\nEmployee {employee.Name} {employee.Surname} received the evaluation results:");
Console.WriteLine($"Average : {statisticsDoWhile.Average:N2}");
Console.WriteLine($"Max: {statisticsDoWhile.Max}");
Console.WriteLine($"Min: {statisticsDoWhile.Min}\n");

var statisticsWhile = employee.GetStatisticsWithWhile();

Console.WriteLine("\nStatistic with while");
Console.WriteLine($"\nEmployee {employee.Name} {employee.Surname} received the evaluation results:");
Console.WriteLine($"Average : {statisticsWhile.Average:N2}");
Console.WriteLine($"Max: {statisticsWhile.Max}");
Console.WriteLine($"Min: {statisticsWhile.Min}\n");