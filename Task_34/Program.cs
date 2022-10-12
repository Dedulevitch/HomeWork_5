/* Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2 */

Console.Clear();
Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО ЭЛЕМЕНТОВ" + "\t");
int a = int.Parse(Console.ReadLine());
int[] array = new int[a];

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
}

Console.WriteLine("МАССИВ" + "\t");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}

Console.WriteLine("РЕЗУЛЬТАТ" + "\t");

for (int i = 0; i < array.Length; i++)
{
    if (array[i] % 2 == 0) sum += 1;
}
Console.Write(sum); 
Console.ReadLine();

/* int num = 4;
if (num % 2 == 0) Console.WriteLine("Да"); */





