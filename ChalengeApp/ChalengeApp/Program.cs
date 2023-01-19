{
    {
        var myName = "Ewa";
        bool isFemale = true;
        var myAge = 33;

        if (isFemale)
        {
            if (myAge < 30)
            {
                Console.WriteLine("Kobieta poniże 30 lat");
            }
            else if (myAge == 33 && myName == "Ewa")
            {
                Console.WriteLine(myName + ", lat 33");
            }
            else if (myAge > 30)
            {
                Console.WriteLine("Pełnoletnia Kobieta");
            }
        }
        else if (!isFemale)
        {
            if (myAge < 18)
            {
                Console.WriteLine("Niepełnoletni Mężczyzna");
            }
            else if (myAge == 36 && myName == "Szymon")
            {
                Console.WriteLine(myName + ", lat 36");
            }
            else
            {
                Console.WriteLine("Pełnoletni mężczyzna");
            }
        }
    }
}