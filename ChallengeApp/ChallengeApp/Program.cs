//Zadanie domowe dzien 4 

var name = "Ewa";
var sex = "Kobieta";
var age = 33;

if (age < 30 && sex == "Kobieta")
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33)
{
    Console.WriteLine("Ewa lat 33");
}
else if (sex != "Kobieta" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna");
}
else if (sex != "Kobieta" && age >= 18)
{
    Console.WriteLine("Pełnoletni mężczyzna");
}