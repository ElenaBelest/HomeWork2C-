Console.Write ("Enter number: ");
int number = Convert.ToInt32 (Console.ReadLine());

if ((number >= 100) && (number < 1000))
{
int secondnumber = (number % 100) / 10;
Console.WriteLine ("Second number: " + secondnumber);
}
else 
{
    Console.WriteLine ("Bad number");
}