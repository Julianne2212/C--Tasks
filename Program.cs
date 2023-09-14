// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

void Numbers(int number)
{
    
    Console.Write(number + " ");
    number--;
    if(number>0)
        Numbers(number);    

}

Console.Write("Input a number: ");
int number = Convert.ToInt32(Console.ReadLine());
Numbers(number);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.\

int Sum(int min, int max, int sum=0)
{
    if(min<=max)
    {
        sum+=min;
        min++;
        sum = Sum(min, max, sum);
    }
    
    return sum;
}

Console.Write("Input a min: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a max: ");
int max = Convert.ToInt32(Console.ReadLine());
int sum = Sum(min, max);
Console.Write(sum);


//Task 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
int Ackermann(int n, int m, int result=0)
{
    if(n==0)
    {
        result = m+1;
    }
    if(m==0)
    {
        result= Ackermann(n-1, 1, result);
    }
    if(n>0 && m>0)
    {
       
        result = Ackermann(n-1, Ackermann(n, m-1, result), result);
    }

    return result;
}
Console.Write("Input number N: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.Write("Input number M: ");
int M = Convert.ToInt32(Console.ReadLine());
int result = Ackermann(N, M);
Console.Write(result);