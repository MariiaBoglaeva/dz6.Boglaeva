// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

Console.WriteLine("Введите числа через запятую: ");
string[] numbers = Console.ReadLine().Split(new char[] { ',' }); // Сразу разбиваем строку на элементы, разделитель - ','
int[] arrayNumbers = StringToArray(numbers);
int countPositiveNum = CountPositiveNum(arrayNumbers);
Console.WriteLine($"Количество введеных чисел больше нуля -> {countPositiveNum}");

int CountPositiveNum(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count += 1;
    }
    return count;
}

int[] StringToArray(string[] num)
{
    int[] array = new int[num.Length];
    for (int i = 0; i < num.Length; i++)
    {
        array[i] = Convert.ToInt32(num[i]);
    }
    return array;
}
