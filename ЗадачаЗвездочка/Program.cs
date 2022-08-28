Console.Write ("Enter number: ");
int number = Convert.ToInt32 (Console.ReadLine());

if ((number % 7 == 0) && (number % 23 == 0))
{
    Console.WriteLine ("Number is a multiple of 7 and 23!");
}
else
{
    Console.WriteLine ("Number is NOT a multiple of 7 and 23");
}
