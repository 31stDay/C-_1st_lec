int[] array = { 1, 2, 5, 99, 6, 78, 99, 25, 44 };
int n = array.Length;
int find = 99;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
     index++;
}

