// Максимальное из 3 чисел
int a = 10, b = 34, c = 76;
int result1 = max1;
int max1(int a, int b)
{
    if (a > b) return a; else return b;

}

int max2 (int b, int c)
{
    if (b>c) return b; else return c;
}
int max (max1,max2)
{
    if (max1>max2) return max1; else return max2;
}
Console.WriteLine(max (max1,max2);

