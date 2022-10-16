/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.Write("Введите длину массива - ");
int N = Convert.ToInt32(Console.ReadLine());
int minN = 100;
int maxN = 1000;
int summ = 0;


int[] array = new int[N];
Random myRandom = new Random();
 
Console.Write("[");
for (int i = 0; i < N; i++)
{
    if(i < N - 1 )
    {
    array[i] = myRandom.Next(minN, maxN);
    Console.Write(array[i] +  ", ");
    }
    else 
    {
    array[i] = myRandom.Next(minN, maxN);
    Console.Write(array[i]);
    }

        if (array[i] % 2 == 0)
    {
        summ++;
    }

}
Console.Write("]" + " - Колличество четных чисел = " + summ);

/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19

[-4, -6, 89, 6] -> 0
*/

Console.Write("Введите длину массива - ");
int N = Convert.ToInt32(Console.ReadLine());
int minN = -100;
int maxN = 100;
int summ = 0;

int[] array = new int[N];
Random myRandom = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = myRandom.Next(minN, maxN);
    Console.Write(array[i] + " ");
    if( i % 2 == 1)
    {
         summ += array[i];
    }
}
    Console.Write("Сумма нечентых позиций массива = " + summ);

// /*
// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76
// */

Console.Write("Введите длину массива - ");
int N = Convert.ToInt32(Console.ReadLine());
int minN = 1;
int maxN = 100;
double min = Int32.MaxValue;
double max = Int32.MinValue;

int[] array = new int[N];
Random myRandom = new Random();

Console.Write("[");
for (int i = 0; i < array.Length; i++)
{
    if (i < array.Length - 1){
            array[i] = myRandom.Next(minN, maxN);
    Console.Write(array[i] + ", ");
    }
    else{
    array[i] = myRandom.Next(minN, maxN);
    Console.Write(array[i]);
    }

    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }

}
Console.Write("]" + " Разница между максимальным и минимальным элементом массива = " + (max - min));
