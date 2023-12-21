var name = "Ewa";
bool men = false;
var age = 29;

if (men == false)
{
    if (name == "Ewa" && age == 30)
    {
        Console.WriteLine("Ewa lat 30");
    }
    else if (age < 30)
    {
        Console.WriteLine("Kobieta poniżej 30 lat");
    }
}
else
{
    if (age < 18)
    {
        Console.WriteLine("niepelnoletni meszczyzna");
    }
}