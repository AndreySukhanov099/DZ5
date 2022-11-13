//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] NewArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next(99, 1000);
    }
    return array;
}

int CountEvenNumbers (int[] array)
{
    int count =0;
    for (int i =0; i < array.Length;i++)
    {
        if(array[i] % 2 == 0)
           count++;
    }
    return count;
}
Console.WriteLine("Введите размер массива");
int number = int.Parse(Console.ReadLine()!);
if(number > 0)
{
    int[] array = new int[number];
    array = NewArray(array);
    Console.WriteLine("["+ string.Join(", ", array) +"]");
    Console.WriteLine("количество чётных чисел в массиве: " + CountEvenNumbers(array));
}
else
Console.WriteLine("Неверный размер массива");