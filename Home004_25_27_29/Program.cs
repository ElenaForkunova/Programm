/*Задача 25: Напишите программу, которая принимает на вход два числа (A и B)
и возводит число A в натуральную степень B.
Для решения задания использование цикла for является обязательным условием.
Не использовать встроенный метод возведения в степень.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int GetFact(int number1, int number2)
{
    int fact = 1;
    number2 = Math.Abs(number2);
    for (int i = 1; i <= number2; ++i)
    {
        fact = number1 * fact;
    }
    return fact;
}

Console.WriteLine("Введите числа А и В: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

int fact = GetFact(number1, number2);
Console.WriteLine(fact);

/*Задача 27: Напишите программу, которая принимает на вход число 
и выдаёт сумму цифр в числе.
Для решения задания использование цикла for является обязательным условием
452 -> 11
82 -> 10
9012 -> 12 */
//Идея сделать число массивом и просуммировать

Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
string str = number.ToString();
int[]array = new int[str.Length];

/*for(int i=0; i < str.Length; i++)
{
    array[i] = int.Parse(str[i].ToString());
} //не сработало*/

    int sum = 0;
    for (int i = 0; i < str.Length; i++)
    {
        array[i] = int.Parse(str[i].ToString());
        sum += array[i];
                
    }
    Console.WriteLine(sum);
//по задаче 27 вопрос, программа работает, но выдает серые ошибки, почему?


/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов 
и выводит их на экран. Заполнение массива производит пользователь.
1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] mass = new int[8];

for (int i = 0; i < mass.Length; i++)
{
    Console.Write($"Введите элемент массива под номером {i}: ");
    mass [i] = Convert.ToInt32(Console.ReadLine());
}

for (int i = 0; i < mass.Length; i++)
{
    Console.Write(mass[i] + ", ");
}

//Вопрос: как вывести массив в квадратных скобках? [1,2,4,5]