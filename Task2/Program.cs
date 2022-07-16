/*  Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12 */

int Prompt (string message)
{
Console.Write (message);
int a = int.Parse (Console.ReadLine ());
return a;
}


int number = Prompt ("Введите число ");
int sum = 0;
int result = 0;

for (int i = 1; i <= number; i++)
{
    result = number % 10;
    number = number / 10;
    sum = result + sum;
}

    Console.WriteLine(sum);

