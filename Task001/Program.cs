// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число А");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B");
int b = Convert.ToInt32(Console.ReadLine());
if (b > 0)
{
    int c = a;

    for (int i = 2; i <= b; i++)
    {
        c = c * a;
    }

    Console.WriteLine($"Число {a} в {b} степени равняется {c}");
}
else
{
    Console.WriteLine("Вы ввели не натуральное число");
}
