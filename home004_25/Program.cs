/*Задача 25: Напишите программу, которая принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
Для решения задания использование цикла for является обязательным условием.
Не использовать встроенный метод возведения в степень.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int GetFac(int number1, int number2)
{
    int fac = 1;
    number2 = Math.Abs(number2);
    for (int i = 1; i <= number2; ++i)
    {
        fac = number1 * fac;
    }
    return fac;
}

Console.WriteLine("Введите числа А и В: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int fac = GetFac(number1, number2);
Console.WriteLine(fac);