int[] numbers = { 12, 45, 7, 89, 34, 23 };
int max = numbers[0];

for (int i = 1; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
}

Console.WriteLine($"Массив: {string.Join(", ", numbers)}");
Console.WriteLine($"Максимальный элемент: {max}");