using ChalengeApp;

Console.WriteLine();
Console.WriteLine("                        Welcome to the SiMoN employee evaluation program                       ");
Console.WriteLine("===============================================================================================");
Console.WriteLine();

Console.WriteLine("Enter the employee's data and his ratings, or end the program by selecting q from the keyboard\n\n");

Console.WriteLine("Enter the name of the employee:");
var name = Console.ReadLine();

Console.WriteLine("Enter the surname of the employee:");
var surname = Console.ReadLine();

var employee = new Employee(name, surname);

while (true)
{
    Console.WriteLine("Enter the next grade from 0 to 100, or from A to F and press Enter");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch(Exception ex) 
    {
        Console.WriteLine($"{ex.Message}");
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine("----------------------------------------------------------------");
Console.WriteLine($"\nEmployee {employee.Name} {employee.Surname} received the evaluation results:");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Average Letter is {statistics.AverageLetter}\n");