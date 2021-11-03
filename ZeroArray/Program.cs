// Обнуление массива

int[] a; // описание масисва (квадратные скобки обозначают массив)
a = new int[10]; //создание массива
//первый способ
int i;
i = 0;
while (i < 10)
{
    a[i] = 0;
    ++i;
}
//второй способ
for (int j = 0; j < 10; ++j)
{
    a[j] = 0;
}
for (i=0;i<10;++i)
{
    Console.WriteLine (a[i]);
}

//Ввод массива с клавиатуры
for (int k = 0; k < 10; ++k)
{
    string s = Console.ReadLine();
    a[k]=Convert.ToInt32(s);
    Console.Write(a[k]+" ");

}
