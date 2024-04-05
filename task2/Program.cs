// Задача 2: Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

int ack(int n, int m)
{
    // System.Console.WriteLine($"n={n}; m={m}");
    if (n == 0)
    {
        return m + 1;
    }
    else if (m == 0)
    {
        return ack(n - 1, 1);
    }
    else
    {
        return ack(n - 1, ack(n, m - 1));
    }
}
System.Console.Write("Введите число m: ");
int m = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число n: ");
int n = Convert.ToInt32(Console.ReadLine());
int result = ack(n, m);
System.Console.WriteLine(result);