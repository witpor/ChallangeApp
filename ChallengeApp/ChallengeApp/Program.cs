var sex = "F";
var name = "Ewa";
var age = 33;

if (sex == "F" && name == "Ewa" && age == 33)
{
    Console.WriteLine(name + ", lat " +  age);
}

else if (sex != "F" && age < 18)
{
    Console.WriteLine("Niepełnoletni Mężczyzna"); 
}
else if (sex == "F" && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30");
}
else
    Console.WriteLine("Dane są spoza zakresu");