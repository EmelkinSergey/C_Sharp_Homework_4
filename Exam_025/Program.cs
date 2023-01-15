// Задача 25: Напишите цикл, который принимает на вход два числа (A и B)
// и возводит число A в натуральную степень B.
Console.WriteLine("Введите первое натуральное число...");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе натуральное число...");
int B = Convert.ToInt32(Console.ReadLine());

int Exponentation(int num1, int num2)
{
    int exp = 1;
    for (int i = 1; i<=(num2); i++)
    {
        exp = exp * (num1);
    }
    return exp;
}

Console.WriteLine($"Число {A} в степени {B} равно {Exponentation(A, B)}");
