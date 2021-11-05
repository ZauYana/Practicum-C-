//вывести случайный массив из 30 элементов (набор чисел может быть от 0 до 100) Описать как найти произведение всех четных чисел и не заканчивающихся на 0 чисел из массива




int[] CreateArray(int n)
{
    int[] a = new int[n];
    Random random = new Random();
    for (int i = 0; i < n; i++) a[i] = random.Next(0, 101);
    return a;
}
void PrintArray(int[] a)
{
    for (int i = 0; i < a.Length; i++) Console.Write(a[i] + " ");
}
int[] arr = CreateArray(3);
PrintArray(arr);
Console.WriteLine();
int p = 1;
for (int i = 0; i < arr.Length; i++)
    if (arr[i] % 2 == 0 && arr[i] % 10 != 0)
    {
        p = p * arr[i];

    }
Console.WriteLine(p);
