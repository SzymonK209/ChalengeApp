using System.Diagnostics.CodeAnalysis;

internal class Program
{
    private static void Main(string[] args)
    {

        int number = 4566;
        string numberToString = number.ToString();
        char[] letters = numberToString.ToArray();
        List<char> numbers = new List<char>();
        numbers.Add('0');
        numbers.Add('1');
        numbers.Add('2');
        numbers.Add('3');
        numbers.Add('4');
        numbers.Add('5');
        numbers.Add('6');
        numbers.Add('7');
        numbers.Add('8');
        numbers.Add('9');

        Console.WriteLine($"Wynik dla liczby:" + number);

        foreach (var num in numbers)
        {
            int count = 0;
            foreach (var let in letters)
            {
                if (num == let)
                {
                    count++;
                }
            }

            Console.WriteLine(num + "=>" + count);
        }

    }


}