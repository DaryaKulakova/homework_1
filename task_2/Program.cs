//Напишите программу 
// которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.

//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

//1.вводим 3 числа a. b. c.
//2.говорим что a = max
//3.сравниваем все числа с max


Console.WriteLine("Введите 3 числа:");
int number_a = Convert.ToInt32(Console.ReadLine());
int number_b = Convert.ToInt32(Console.ReadLine());
int number_c = Convert.ToInt32(Console.ReadLine());

int max = number_a;

if (number_b > max)
{
max = number_b;
}

if (number_c > max)
{
max = number_c;
}

Console.WriteLine("Наибольшее из введённых чисел -> " + max);