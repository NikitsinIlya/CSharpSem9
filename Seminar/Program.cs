// необходимо возвести число А в степень b
/*
int f(int a, int b)
{
    if(b == 0)
        return 1;
    return f(a, b - 1) * a;
}

Console.Clear();
Console.WriteLine(f(3,5));
*/ 
// Task 63
// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N
/*
string f(int n)
{
    if (n == 1)
        return "1";
    return f (n - 1) + $", {n}";
}
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
*/
// Task 65
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
/*
string f(int m, int n )
{
    if (m == n)
        return $"{m}";
    return f (m, n - 1) + $", {n}";
}

Console.Clear();
Console.WriteLine("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(m, n));

*/ 

// Task 67
// Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
/*
int f(int n)
{
    if (n < 10)
        return n;
    return f (n / 10) + n % 10;
}
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));
*/
// Требуется найти N-е число Фибоначчи.
int f(int n)
{
  if (n == 0) 
    return 0;
  if (n == 1) 
    return 1;
  return f(n - 1) + f(n - 2);
}

Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(f(n));