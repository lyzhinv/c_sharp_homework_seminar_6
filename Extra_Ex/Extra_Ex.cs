// Найти произведение всех элементов массива целых чисел, меньших заданного числа. Размерность массива –10. Заполнение массива осуществить случайными числами от 50 до 100.

Console.WriteLine("Введите число от 50 до 100");
int N = int.Parse(Console.ReadLine()!);
int[] BaseArray = GetArray(10, 50, 100);

if (N >= 50 && N <=100) Console.WriteLine($"Произведение чисел меньших числа '{N}' в массиве {String.Join(", ", BaseArray)} -> {GetResult(BaseArray, N)}");
else Console.WriteLine("Введено не верное число");


int GetResult (int[] array, int number) // метод осущестляющий умножение всех элементов массива, меньших заданного числа N, 
{
    int result = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <= number) result = result * array[i];
    }

    if (result == 1) return result = 0;
    else return result;
}


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}