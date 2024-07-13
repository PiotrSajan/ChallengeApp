// Zadanie domowe dzien 4 
var name = "Karolina";
var sex = "female";
var age = 27;

if (sex == "female" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat.");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30.");

}
else if (!(sex == "female") && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna.");
}