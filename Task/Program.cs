﻿/*
Почувствуй себя интерном
 0. Вывести квадрат числа
 1. По двум заданным числам проверять является ли первое квадратом второго
 2. Даны два числа. Показать большее и меньшее число
 3. По заданному номеру дня недели вывести его название
 4. Найти максимальное из трех чисел
 5. Написать программу вычисления значения функции y=f(a)
 6. Выяснить является ли число чётным
 7. Показать числа от -N до N
 8. Показать четные числа от 1 до N
 9. Показать последнюю цифру трёхзначного числа
10. Показать вторую цифру трёхзначного числа
11. Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
12. Удалить вторую цифру трёхзначного числа
13. Выяснить, кратно ли число заданному, если нет, вывести остаток.
14. Найти третью цифру числа или сообщить, что её нет
*/

//0. Вывести квадрат числа

int MyDouble(int n)
{
    n = n*n;
    return n;
}

int b = 5;
Console.WriteLine(MyDouble(b));

//1. По двум заданным числам проверять является ли первое квадратом второго

void MyScuare(int a, int b)
{
    if(a == b*b)
    {   
        Console.WriteLine($"{a} является квадратом {b}");
    }
    else
    {
        Console.WriteLine($"{a} не является квадратом {b}");
    }

}

// нужно как-то  Console.WriteLine из тела метода убрать... у меня ошибки выдаёт

int n = 25;
int d = 5;

MyScuare(n, d);

//2. Даны два числа. Показать большее и меньшее число

void MaxMin(int a, int b)
{
    if(a > b)
    {
        Console.WriteLine($" max = {a}, min = {b}");
    }
    else
    {
        Console.WriteLine($" max = {b}, min = {a}");
    }
}

MaxMin(1, 3);

//и здесь тоже.

// 3. По заданному номеру дня недели вывести его название

string[] day = new string[7] { "Monday", "Tuesday", "Wensday", "Thursday", "Friday", "Sunday", "Saturday" };
int w = int.Parse(Console.ReadLine());
if ((w >= 1) && (w <= 7))
{
    Console.WriteLine(day[w - 1]);
}
else
{
    Console.WriteLine("неверный номер");
}

//4. Найти максимальное из трех чисел

int m (int a, int b, int c)
{
    int max = a;
    if (b > max) max = b;
    if (c > max) max = c;
    return max;
}

Console.WriteLine(m(1, 2, 3));

//5. Написать программу вычисления значения функции y=f(a)
// f = sin

double func(int num)
{
    double result = Math.Sin(num);
    return result;
}

int a = 30;
double y = func(a);
Console.WriteLine(y);