using ChalengeApp;

Console.WriteLine();
Console.WriteLine("                Welcome to the SiMoN employee evaluation program                 ");
Console.WriteLine("=================================================================================");
Console.WriteLine();

var employee = new Employee();

Console.WriteLine("Enter the employee's ratings, or end the program by selecting q from the keyboard");
Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++++\n");

while (true)
{
    Console.WriteLine("Enter the next grade from 0 to 100, or from A to F and press Enter");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}

var statistics = employee.GetStatistics();

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine($"\nEmployee received the evaluation results:");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Average Letter is {statistics.AverageLetter}\n");