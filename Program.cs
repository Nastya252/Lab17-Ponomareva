// int[] scores = { 60, 80, 40, 80, 90 };

int Sum(int[] numbers)
{
    int summa = 0;
    foreach (int num in numbers)
    {
        summa += num;
    }
    return summa;
}
// Console.WriteLine(Sum(new int[] { 5, -2, 7 }));

int CountAtLeast(int[] numbers, int limit)
{
    int count = 0;
    foreach (int number in numbers)
    {
        if (number >= limit)
        {
            count++;
        }
    }
    return count;
}
// Console.WriteLine(CountAtLeast(scores, 50));

// int CountAtLeast(int[] numbers, int limit)
// {
//     int count = 0;
//     foreach (int number in numbers)
//     {
//         if (number >= limit)
//         {
//             count++;
//         }
//     }

//     return count;
// }
// Console.WriteLine(CountAtLeast(new int[] { 40, 50, 80 }, 50));

int Min(int[] numbers)
{
    int min = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] < min)
        {
            min = numbers[i];
        }
    }
    return min;
}
// Console.WriteLine(Min(scores));

int Max(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }
    return max;
}
// Console.WriteLine(Max(scores));

// TODO
// int FindMin(int[] numbers)
// {
//     int min = 0;
//     foreach (int number in numbers)
//     {
//         if (number < min)
//         {
//             min = number;
//         }
//     }
//     return min;
// }
// Console.WriteLine(FindMin(new int[] { 12, 4, 9 }));

//TODO
// int FindIndex(int[] numbers, int target)
// {
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == 80)
//         {
//             return i;
//         }
//     }
//     return -1;
// }
// Console.WriteLine(FindIndex(scores, 80));
// Console.WriteLine(FindIndex(scores, 100));

// int FindIndex(int[] numbers, int target)
// {
//     int index = -1;
//     for (int i = 0; i < numbers.Length; i++)
//     {
//         if (numbers[i] == target)
//         {
//             index = i;
//             break;
//         }
//     }
//     return index;
// }
// Console.WriteLine(FindIndex(scores, 80));
// Console.WriteLine(FindIndex(scores, 60));
// Console.WriteLine(FindIndex(scores, 100));



int[] scores = new int[7];
for (int i = 0; i < scores.Length; i++)
{
    Console.Write($"Результат {i + 1}: ");
    scores[i] = Convert.ToInt32(Console.ReadLine());
}
Console.WriteLine("        >>> Анализ результатов <<<");
Console.WriteLine(Sum(scores));
Console.WriteLine(Min(scores));
Console.WriteLine(Max(scores));
Console.WriteLine(CountAtLeast(scores, 50));