using ChalengeApp;

Employee employee1 = new Employee("Szymon", "Kowalik", "36");
Employee employee2 = new Employee("Jan", "Kowalski", "27");
Employee employee3 = new Employee("Janusz", "Nowak", "53");

employee1.Addscore(9);
employee1.Addscore(5);
employee1.Addscore(7);
employee1.Addscore(6);
employee1.Addscore(10);

employee2.Addscore(5);
employee2.Addscore(2);
employee2.Addscore(3);
employee2.Addscore(8);
employee2.Addscore(4);

employee3.Addscore(7);
employee3.Addscore(5);
employee3.Addscore(4);
employee3.Addscore(1);
employee3.Addscore(9);

if (employee1.Result >= employee2.Result && employee1.Result >= employee3.Result)
{
    Console.WriteLine($"Pracownik z najwyższą sumą ocen: {employee1.Result} pkt \n{employee1.Name} {employee1.Surname} lat {employee1.Age}");
}
if (employee2.Result >= employee1.Result && employee2.Result >= employee3.Result)
{
    Console.WriteLine($"Pracownik z najwyższą sumą ocen: {employee2.Result} pkt \n{employee2.Name} {employee2.Surname} lat {employee2.Age}");
}
if (employee3.Result >= employee1.Result && employee3.Result >= employee2.Result)
{
    Console.WriteLine($"Pracownik z najwyższą sumą ocen: {employee3.Result} pkt \n{employee3.Name} {employee3.Surname} lat {employee3.Age}");
}