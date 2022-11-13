//Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

int[] NewArray(int[] array)
{
    for(int i =0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-1000, 1000);
    }
    return array;
}

int MaxNumbers(int[] array)
{
    int max = array[0];
    for (int i =0; i < array.Length; i ++)
    {
        if(max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}
int MinNumbers(int[] array)
{
    int min = array[0];
    for (int i =0; i < array.Length; i ++)
    {
        if(min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}
Console.WriteLine("Введите размер массива");
int number = int.Parse(Console.ReadLine()!);
if(number > 0)
{
    int[] array = new int[number];
    array = NewArray(array);
    Console.WriteLine("["+ string.Join(", ", array) +"]");
    Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + (MaxNumbers(array) - MinNumbers(array)));
}
else
Console.WriteLine("Неверный размер массива");