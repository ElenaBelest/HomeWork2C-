Console.Write ("Enter number: ");
int number = Convert.ToInt32 (Console.ReadLine());

if ((number >= 100) && (number < 1000))
{
int lastnumber = number % 10;
Console.WriteLine ("Last number: " + lastnumber);
}
else if (number > 1000)
{
    Console.WriteLine ("Bad number");
}

else if (number < 100)
{
    Console.WriteLine ("Last number no");
}

