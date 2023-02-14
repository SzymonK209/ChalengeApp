using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using ChalengeApp;

Console.WriteLine();
Console.WriteLine("                        Welcome to the SiMoN employee evaluation program                       ");
Console.WriteLine("===============================================================================================");
Console.WriteLine();

Console.WriteLine("Enter the employee's data and his ratings, or end the program by selecting Q from the keyboard\n\n");

Console.WriteLine("Enter the name of the employee:");
var name = Console.ReadLine();

Console.WriteLine("Enter the surname of the employee:");
var surname = Console.ReadLine();

string sex;

while (true)
{
    Console.WriteLine("Enter the sex of the employee:\n M - male, F - female");
    var sexin = Console.ReadLine();
    if (sexin == "M" || sexin == "m")
    {
        sex = "Male";
        break;
    }
    else if (sexin == "F" || sexin == "f")
    {
        sex = "Female";
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"[{sexin}] is incorect gender");
        Console.ResetColor();
    }
}

int age;

while (true)
{
    Console.WriteLine("Enter the age of the employee:");
    bool ageInInt = int.TryParse(Console.ReadLine(), out age);
    if (age > 0 && age <= 200)
    {
        break;
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Invalid age value! \n");
        Console.ResetColor();
    }

}

var employee = new Employee(name, surname, sex, age);

while (true)
{
    Console.WriteLine("Enter the next grade from 0 to 100, or from A to F and press Enter");
    var inputGrade = Console.ReadLine();
    if (inputGrade == "q" || inputGrade == "Q")
    {
        break;
    }
    try
    {
        employee.AddGrade(inputGrade);
    }
    catch (Exception ex)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{ex.Message}");
        Console.ResetColor();
    }
}

var statistics = employee.GetStatistics();

Console.WriteLine("----------------------------------------------------------------");
Console.ForegroundColor= ConsoleColor.DarkGreen;
Console.WriteLine($"\nEmployee {employee.Name} {employee.Surname}  {employee.Sex} {employee.Age}years old received the evaluation results:");
Console.WriteLine($"Average : {statistics.Average:N2}");
Console.WriteLine($"Max: {statistics.Max:N2}");
Console.WriteLine($"Min: {statistics.Min:N2}");
Console.WriteLine($"Average Letter is {statistics.AverageLetter}\n");
Console.ResetColor();