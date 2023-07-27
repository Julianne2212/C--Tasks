// Задача 2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    Console.Write("max = " + a);
    Console.Write("min = " + b);
}
else 
{
    Console.Write("max = " + b);
    Console.Write("min = " + a);
}
*/

// Задача 4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел
/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());
if ((a>b) && (a>c))
{
    Console.WriteLine ("max = " + a);
}
else if ((b>a) && (b>c))
{
    Console.WriteLine ("max = " + b);
}
else 
{
   Console.WriteLine ("max = " + c); 
}
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка)
/*
Console.WriteLine("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
if (a%2 == 0) 
{
    Console.WriteLine("число четное");
}
else 
{
    Console.WriteLine("число нечетное");
}
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа
/*
Console.WriteLine("Введите положительное число: ");
int a = Convert.ToInt32(Console.ReadLine());
int counter = 1; 
while (counter<a)
{   if(counter%2 == 0) 
   {
    Console.Write (counter + " ");
    counter++;
   }
   else 
   {
    counter++;
   }
}
*/
