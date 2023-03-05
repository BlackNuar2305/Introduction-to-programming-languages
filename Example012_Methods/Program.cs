// Viev 1
void Method1()
{
    System.Console.WriteLine("Author");
}

// Viev 2

void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

//Viev 3


int Method3()
{
    return DateTime.Now.Year;
}



//Viev 4

string Method4(int count, string c)
{
    int i = 0;
    string result = string.Empty;

    while (i < count)
    {
        result = result + c;
        i++;
    }
    return result;
}

//for (int i = 2; i < 10; i++)
// {
//     for (int j = 1; j < 10; j++)
//     {
//         System.Console.WriteLine($"{i} * {j} = {i * j}");
//     }
//     System.Console.WriteLine();
// }

// string text = "- Я думаю, - сказал князь, улыбаясь, - что, ежели бы вас послали всесто милого Винценгероде, вы бы взыли приступов согласие прусского короля. Вы так краснорячивы. Вы дадите мне чаю?";

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = string.Empty;
//     int length = text.Length;

//     for (int i = 0; i < length; i++)
//     {
//         if (text[i] == oldValue) result += $"{newValue}";
//         else result += $"{text[i]}";
//     }



//     return result;
// }

// string newText = Replace(text, ' ', '|');
// System.Console.WriteLine(newText);
// System.Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// System.Console.WriteLine(newText);




int[] arr = {1, 5, 24, 3, 2346, 46, 2256, 2345, 2345};


void PrintArray(int[] array)
{
    int count = array.Length;

    for (int i = 0; i < count; i++)
    {
        System.Console.Write($"{array[i]} ");
    }
    System.Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition]) minPosition = j;
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);