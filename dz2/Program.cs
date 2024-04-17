// Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два
// неотрицательных числа m и n.



int FuncAkkerman(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (m == 0)
        return FuncAkkerman(n - 1, 1);
    else return FuncAkkerman(n - 1, FuncAkkerman(n, m - 1));

}

void NaturalNumTest(int n, int m)
{
    if (n < 0 || m < 0)
    {
        Console.WriteLine("Числа не натуральные");
        Environment.Exit(0); 
    }

}
Console.WriteLine("Введите значение n");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите значение m");
int m = Convert.ToInt32(Console.ReadLine());

NaturalNumTest(n, m);
int result = FuncAkkerman(n, m);
Console.WriteLine(result);
