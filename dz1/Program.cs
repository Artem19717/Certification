// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

void NaturalNumbers(int num1, int num2)
{
    if (num2 < num1)
    {
        int temp = num1;
        num1 = num2;
        num2 = temp;
    }

    if (num1 == num2)
    {
        Console.WriteLine("Числа равны");

    }

    NaturalNumbersRecursive(num1, num2);
}

void NaturalNumbersRecursive(int num1, int num2)
{
    if (num1 <= num2)
    {
        Console.Write($"{num1} ");
        NaturalNumbersRecursive(num1 + 1, num2);
    }
}

Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());
NaturalNumbers(n, m);
