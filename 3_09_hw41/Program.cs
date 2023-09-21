/*Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3
*/

int InputNumber(string massege)
{
    Console.WriteLine(massege);
    return int.Parse(Console.ReadLine()!);
}

int[] CreateAray(int size)
{
    return new int[size];
}

void Fillarray(int[] array)
{
    Console.WriteLine("Введите числа");
    for ( int i = 0; i < array.Length; i ++)
    {
        array[i] = int.Parse(Console.ReadLine()!);
    }
}

int CountPos(int[] array)
{
    int count = 0;
    for ( int i = 0; i < array.Length; i ++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

int M = InputNumber("введите число элементов");
int [] arr = CreateAray(M);
Fillarray(arr);
Console.WriteLine($"Количество чисел больше нуля:  {CountPos(arr)}");