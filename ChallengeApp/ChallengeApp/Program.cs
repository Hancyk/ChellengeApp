var name = "Ewa";
var sex = "K";
var age = 20;

if (sex == "K")
{
    if (age < 30)
        Console.WriteLine("Kobieta poniżej 30 lat");
    else if (age == 30 && name == "Ewa")
        Console.WriteLine("Ewa lat 30");
    else
        Console.WriteLine("");

}
else if (age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("");
}