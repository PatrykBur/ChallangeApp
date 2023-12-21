var name = "Ewa";
bool men = true;
var wiek = 30;

if (men == false)
{
    if (wiek >= 30)
    {
        if (name == "Ewa")
        {
            Console.WriteLine("Ewa lat 30");
        }
        else
        {
            Console.WriteLine("Kobieta 30 lat");
        }
    }
    else
    {
        Console.WriteLine(" ");
    }
}
else
{
    if (wiek >= 18)
    {
        Console.WriteLine(" ");
    }
    else
    {
    Console.WriteLine("niepelnoletni meszczyzna");
    }
}
