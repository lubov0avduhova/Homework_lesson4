/*  Задача 1: Напишите цикл, который принимает на вход два числа (A и B) 
и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16 */

int Prompt (string message)
{
Console.Write (message);
int a = int.Parse (Console.ReadLine ());
return a;
}

int number = Prompt ("Введите число ");
int raised = Prompt ("Введите степень числа ");
int result = 1;


for (int i = 0; i < raised; i++)
{
    result = number * result;
}
System.Console.WriteLine(result);