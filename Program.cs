Console.WriteLine("Введите цифры 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цифры 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());


if (number2 > number1 )
  {  
    int max = number2;
    int min = number1; 
    Console.WriteLine("max: ");
    Console.WriteLine( max);
    Console.WriteLine("min: ");
    Console.WriteLine(min);
}
else
  {    
    int max = number1;
    int min = number2; 
    Console.WriteLine("max: ");
    Console.WriteLine( max);
    Console.WriteLine("min: ");
    Console.WriteLine(min);
}   
 

