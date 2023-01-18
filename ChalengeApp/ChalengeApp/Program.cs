
string myName = "Ewa";
char sex = 'K';
var myAge = 33;

if (sex == 'K' && myAge < 30)
{
    Console.WriteLine("Kobieta poniże 30 lat");
}
else
{
    if (myName == "Ewa" && sex == 'K' && myAge == 33)
    {
        Console.WriteLine("Ewa, lat 33");
    }
    else
    {
        if (sex != 'K' && myAge < 18)
        {
            Console.WriteLine("Niepełnoletni Mężczyzna");
        }
        else
        {
            Console.WriteLine("Pełnoletni mężczyzna");
        }
    }
}
