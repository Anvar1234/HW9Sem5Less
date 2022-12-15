/*
Пояснения и примечания:
1. Все задачи решал, используя хотя бы один метод(функцию).
2. В задаче 38 реализовал метод поиска мин и макс в массиве параллельным(?) поиском с обоих концов массива. Не знаю,
рабочий ли этот метод на практике и сокращает ли он количество итераций/времени исполнения программы, но мне хотелось реализовать 
подобное, почему-то кажется, что это должно сократить время поиска значений)) Я не знаю, стоит ли так "оптимизировать" 
алгоритм поиска, может он не дает никакого преимущества, поэтому прошу в ответе написать, нужно/не нужно так делать, насколько 
это практично, насколько требуемо, какие ошибки и т.п. Очень спасибо!)
*/






/*
ДОПОЛНИТЕЛЬНАЯ 
Задача 37: Найдите произведение пар чисел в одномерном массиве.
Парой считаем первый и последний элемент, второй и предпоследний
и т.д. Результат запишите в новом массиве.
[1 2 3 4 5] -> 5 8 3
[6 7 3 6] -> 36 21
*/

/*
int[] Array(int size, int left, int right) //объявляем метод Array, который используется для заполнения массива рандомными значениями в количестве "size" штук.
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(left, right + 1);
    }
    return newArray;
}

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int numberValues = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите min возможное значение массива: ");
int leftBorder = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите max возможное значение массива: ");
int rightBorder = Convert.ToInt32(Console.ReadLine());

if (leftBorder > rightBorder)
{
    Console.WriteLine("Не хитри, min граница должна быть меньше, чем max!");
}

int[] resultArray = Array(numberValues, leftBorder, rightBorder);
Console.WriteLine($"[{String.Join(" ", resultArray)}]");

int multiplNumb = 0;

if (numberValues % 2 == 0)
{
    for (int i = 0; i < numberValues / 2; i++)
    {
        multiplNumb = resultArray[i] * resultArray[(numberValues - 1) - 1 * i];
        Console.Write($"{multiplNumb} ");
    }
}
if (numberValues % 2 == 1)
{
    for (int i = 0; i < numberValues / 2; i++)
    {
        multiplNumb = resultArray[i] * resultArray[(numberValues - 1) - 1 * i];
        Console.Write($"{multiplNumb} ");
    }
    Console.Write($"{resultArray[numberValues / 2]} ");
}

*/







/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными 
числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
*/

/*
int[] GetArray(int size) //объявляем метод GetArray, который используется для заполнения массива 
                         //рандомными положительными 3х-значными числами в количестве "size" штук.
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(100, 1000);
    }
    return newArray;
}

int GetEvenNumbers(int[] collection) //объявляем метод GetEvenNumbers, который используется для поиска
                                     //количества четных чисел в массиве.
{
    int length = collection.Length;
    int count = 0;
    for (int i = 0; i < length; i++)
    {
        if (collection[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;

}

Console.Clear();

Console.Write("Введите количество элементов массива: ");
int numberOfValues = Convert.ToInt32(Console.ReadLine());

int[] array = GetArray(numberOfValues);
Console.WriteLine($"Получаем массив: [{String.Join(" ", array)}]");

int evenNumbers = GetEvenNumbers(array);
Console.WriteLine($"Количество четных чисел в массиве = {evenNumbers}");
*/







/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, 
стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/


/*
int[] GetArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(-11, 11);
    }
    return newArray;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newMassiv = GetArray(length);
Console.WriteLine($"Получаем массив: [{String.Join("; ", newMassiv)}]");

int sumOfOddPos = 0;

for (int i = 1; i < length; i += 2)
{
    sumOfOddPos = sumOfOddPos + newMassiv[i];
}

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumOfOddPos}");
*/






/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76
*/
/*
Поянение: Здесь реализовал метод поиска мин и макс в массиве параллельным поиском с обоих концов массива. Не знаю,
рабочий ли этот метод на практике и сокращает ли он количество итераций, но мне хотелось реализовать подобное, почему-то
кажется, что это должно сократить время поиска значений)) Я не знаю, стоит ли так "оптимизировать" алгоритм поиска, 
может он не дает никакого преимущества, поэтому прошу в ответе написать, нужно/не нужно так делать, насколько 
это практично, насколько требуемо, какие ошибки и т.п. Очень спасибо!)
*/

/*
int[] GetArray(int size) //метод для генерации массива случ чисел
{
    int[] newArray = new int[size];
    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(-10, 11);
    }
    return newArray;
}

Console.Clear();
Console.Write("Введите размер массива: ");
int length = Convert.ToInt32(Console.ReadLine());
int[] newMassiv = GetArray(length);
Console.WriteLine($"Получаем массив: [{String.Join("; ", newMassiv)}]");

//cоздаем два ПЕРВЫХ метода для нах-я максимума и минимума в МАССИВЕ, КОТОРЫЙ СОСТОИТ ИЗ НЕ МЕНЕЕ чем 4 ЭЛЕМЕНТОВ:

int GetMax1(int[] collection)//максимум массива
{
    int max1 = collection[0];
    int max2 = collection[length - 1];
    int resultMax = 0;
    for (int i = 1; i < length / 2; i++)
    {
        if (collection[i] > max1)
        {
            max1 = collection[i];
        }

        if (collection[(length - 1) - 1 * i] > max2)
        {
            max2 = collection[(length - 1) - 1 * i];
        }
    }
    if (max1 > max2)
    {
        resultMax = max1;
    }
    else resultMax = max2;

    if (length % 2 == 1)
    {
        if (collection[(length / 2)] > resultMax)
        {
            resultMax = collection[(length / 2)];
        }
    }
    return resultMax;
}

int GetMin1(int[] collection)//минимум массива
{
    int min1 = newMassiv[0];
    int min2 = newMassiv[length - 1];
    int resultMin = 0;
    for (int i = 1; i < length / 2; i++)
    {
        if (collection[i] < min1)
        {
            min1 = collection[i];
        }

        if (collection[(length - 1) - 1 * i] < min2)
        {
            min2 = collection[(length - 1) - 1 * i];
        }
    }
    if (min1 < min2)
    {
        resultMin = min1;
    }
    else resultMin = min2;

    if (length % 2 == 1)
    {
        if (collection[(length / 2)] < resultMin)
        {
            resultMin = collection[(length / 2)];
        }
    }
    return resultMin;
}

//cоздаем два метода для нах-я максимума и минимума в МАССИВЕ, КОТОРЫЙ СОСТОИТ ИЗ МЕНЕЕ чем 4 ЭЛЕМЕНТОВ:

int GetMax2(int[] collection)//максимальное значение массива из менее чем 4 значений
{
    int max11 = collection[0];
    for (int i = 1; i < length; i++)
    {
        if (collection[i] > max11)
        {
            max11 = collection[i];
        }
    }
    return max11;
}

int GetMin2(int[] collection)//минимальное значение массива из менее чем 4 значений
{
    int min11 = collection[0];
    for (int i = 1; i < length; i++)
    {
        if (collection[i] < min11)
        {
            min11 = collection[i];
        }
    }
    return min11;
}

if (length >= 4)
{
    int resMax1 = GetMax1(newMassiv);
    int resMin1 = GetMin1(newMassiv);
    int result1 = GetMax1(newMassiv) - GetMin1(newMassiv);
    Console.WriteLine($"Максимальное значение массива = {resMax1}");
    Console.WriteLine($"Минимальное значение массива = {resMin1}");
    Console.WriteLine($"Разность между max и min значениями массива = {result1}");
}
else
{
    int resMax2 = GetMax2(newMassiv);
    int resMin2 = GetMin2(newMassiv);
    int result2 = GetMax2(newMassiv) - GetMin2(newMassiv);
    Console.WriteLine($"Максимальное значение массива = {resMax2}");
    Console.WriteLine($"Минимальное значение массива = {resMin2}");
    Console.WriteLine($"Разность между max и min значениями массива = {result2}");
}

*/