/* Задача 36: Задайте одномерный массив, заполненный случайными числами.
 Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 */

Console.Clear();
Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО ЭЛЕМЕНТОВ" + "\t");
int a = int.Parse(Console.ReadLine()); 
int[] array = new int [a];

int sum = 0;

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 9); 
} 

Console.WriteLine("МАССИВ" + "\t");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}

Console.WriteLine("РЕЗУЛЬТАТ" + "\t");

for (int i = 0; i < array.Length; i++)
{
    if (i % 2 != 0) sum += array[i];
}
Console.Write(sum); 
Console.ReadLine();





