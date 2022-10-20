// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь

int[] BaseArray = GetArray(5, -500, 500);
Console.WriteLine($"Среди заданных чисел {String.Join(", ", BaseArray)} больше '0' -> {PositiveNumbers(BaseArray)}");


int PositiveNumbers(int[] array) // Метод, вычисляющий числа больше 0
{
    int result = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) result = result +1;
    }
    return result;
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
