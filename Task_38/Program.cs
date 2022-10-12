/* Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76 */

Console.Clear();
Console.WriteLine("ВВЕДИТЕ КОЛИЧЕСТВО ЭЛЕМЕНТОВ" + "\t");
int a = int.Parse(Console.ReadLine());
int[] array = new int[a];

for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(1, 1000);
}

Console.WriteLine("МАССИВ" + "\t");
for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + "\t");
}
Console.WriteLine(" ");

int min = array[0];
int max = array[0];

for (int i = 1; i < array.Length; i++)
{

    if (array[i] < min) min = array[i];
    if (array[i] > max) max = array[i]; 

}

int num1 = max;
int num2 = min;
int sum = max - min;
int sum2 = Math.Abs(sum); 
Console.Write($"МИНИМАЛЬНОЕ ЧИСЛО=> {min} МАКСИМАЛЬНОЕ ЧИСЛО => {max}" + "\t"); 
Console.WriteLine(); 
Console.Write($"РАЗНИЦА => {sum2}"); 
Console.ReadLine();



