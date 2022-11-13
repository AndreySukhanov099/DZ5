//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] NewArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}

int SumEvenNumbers (int[] array)
{
    int sum = 0;
    for (int i =0; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

Console.WriteLine("Введите размер массива");
int number = int.Parse(Console.ReadLine()!);
if(number > 0)
{
    int[] array = new int[number];
    array = NewArray(array);
    Console.WriteLine("["+ string.Join(", ", array) +"]");
    Console.WriteLine("Сумма чисел, стоящих на нечетных позициях: " + SumEvenNumbers(array));
}
else
Console.WriteLine("Неверный размер массива");