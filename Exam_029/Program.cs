// Задача 29: Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.


int[] array = NewArray(8);
Console.WriteLine($" [ {String.Join(", ", array)} ] ");


int[] NewArray(int size)
{
int[] num = new int[size];
for (int i = 0; i < size; i++)
{
num[i] = new Random().Next(0,100);
}

return num;
}