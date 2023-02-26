void fill_array(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void print_array(int[] col)
{
    int count = col.Length;
    int position = 0;

    while (position < count)
    {
        System.Console.WriteLine(col[position]);
        position++;
    }
}

int index_off(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}

int[] array = new int[10];

fill_array(array);
print_array(array);

System.Console.WriteLine();
int pos = index_off(array, 4);
System.Console.WriteLine(pos);