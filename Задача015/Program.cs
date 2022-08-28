 Console.Write("Enter number : ");
int number = Convert.ToInt32(Console.ReadLine());

if(number >= 1 && number <= 7 )
 {

switch(number)
 {
 case 1: Console.WriteLine("Monday - No "); break;

 case 2: Console.WriteLine("Tuesday - No "); break;

 case 3: Console.WriteLine("Wednesday - No "); break;

 case 4: Console.WriteLine("Thuesday - No "); break;

 case 5: Console.WriteLine("Friday - No "); break;

 case 6: Console.WriteLine("Saturday - Yes "); break;

 case 7: Console.WriteLine("Sunday - Yes"); break;
 
 }

 }
 else
 {
Console.WriteLine(" Bad number ");
 }
