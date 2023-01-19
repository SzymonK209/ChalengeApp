using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {

        List<string> names = new List<string>();
        names.Add("Adam");
        names.Add("Monika");
        names.Add("Arek");
        names.Add("Szymon");
        names.Add("Agata");
        names.Add("Adam");
        names.Add("Amelia");
        names.Add("Monika");
        names.Add("Jan");
        names.Add("Maksymilian");
        names.Add("Adam");
        names.Add("Nikola");
        names.Add("Adrianna");
        names.Add("Barbara");
        names.Add("Monika");
        names.Add("Adam");
        names.Add("Wojciech");
        names.Add("Franciszka");
        names.Add("Roman");
        names.Add("Adam");

        var sum = 0;
        var sumA = 0;
        var sumB = 0;
        var sumC = 0;
        var sumD = 0;
        
        for (var i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }

        Console.WriteLine("--------------");

        for (int i = 0; i < names.Count; i++)
        {
            sum++;
        }
        Console.WriteLine($"Łącznie jest {sum} osób na liście,");

        for (int i = 0; i < names.Count; i++)
        {
            if (names[i] == "Adam")
            {
                sumA++;
            }
        }
        Console.WriteLine($"imię Adam powtórzyło się {sumA} razy,");

        for (int i = 0; i < names.Count; i++)
        {
            if (names[i] == "Monika")
            {
                sumB++;
            }
        }
        Console.WriteLine($"imię Monika powtórzyło się {sumB} razy,");

        for (int i = 0; i < names.Count; i++)
        {
            if (names[i] == "Arek")
            {
                sumC++;
            }
        }
        Console.WriteLine($"imię Arek powtórzyło się {sumC} raz,");

        sumD = sum - sumA - sumB - sumC;

        Console.WriteLine($"{sumD} imion bez powtórzeń.");
    }


}