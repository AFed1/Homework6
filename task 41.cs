Console.WriteLine("Сколько чисел вы хотите ввести?");
int num = int.Parse(Console.ReadLine()!);
int[] arr = new int[num];

Console.WriteLine($" -> {CountPositiveNumber(UserFillArray(arr))}");

int[] UserFillArray(int[] array)
{
    for (int j = 0; j < num; j++)
    {
        Console.WriteLine($"Введите {j + 1} число");
        arr[j] = int.Parse(Console.ReadLine()!);
    }
    return array;
}

int CountPositiveNumber(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) count++;
    }
    return count;
}