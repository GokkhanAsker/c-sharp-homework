//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите цыфры 1: ,");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цыфры 2: ,");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите цыфры 3: ,");
int c = Convert.ToInt32(Console.ReadLine());
int max =0;
int [] array = { a ,b ,c};
int index = 0 ;
int length = array.Length ;
 while (index< length)
 {
     if (array[index]>max) max=array[index]  ;
     index++;
 }
Console.WriteLine("max: ");
Console.WriteLine (max);