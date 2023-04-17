// 1st type - accept nothing and return nothing 
void Method1()
{
    Console.WriteLine("The author is Chernyshova Dina");
}
Method1();

///////////////////////////////////////////////////////////
//2nd type - accept arguments and return nothing
void Method2(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }

}
Method2(msg: "Message text");
// Method2(msg: "Message text", count: 4);
// Method2(count: 4, msg: "Message text");
// Method2("Message text", 4);

/////////////////////////////////////////////////////////////
//3rd type - accept nothing and return something
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

/////////////////////////////////////////////////////////
//4th type - accept arguments and return something
string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;
    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "adsf");
Console.WriteLine(res);

///////////////////////////////////////////////////////////////
// "For" loop
string MethodF(int count, string text)
{
    string result = String.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = MethodF(10, "forLoop");
Console.WriteLine(res);

///////////////////////////////////////////////////////////
//Loop inside loop
// Multiplication table

for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j}={i * j}");
    }
    Console.WriteLine();
}

////////////////////////////////////////////////////////////////
// Work with text
// In the provided text, replace all spaces with dashes.
// Lowercase "k" replace with uppercase "K",
// and replace uppercase "C" with lowercase "c".

// Is the task clear?

string text = "I think, - prince said, smiling, - that, "
            + "if you had been sent instead of our dear Winzengerode,"
            + "you would have stormed consent from Prussian king."
            + "You are so eloquent. Could you pour me some tea";

// string s = "qwerty"
//             0123
// s[3]  //  r


string Replace(string text, char oldValue, char newValue)
{
    string result = string.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'k', 'K');
Console.WriteLine(newText);
Console.WriteLine();

newText = Replace(newText, 'C', 'c');
Console.WriteLine(newText);
Console.WriteLine();


///////////////////////////////////////////////////////
///////////////////////////////////////////////////////
// Sorting algorithms
// Selection sort: finding the maximum and minimum elements

// Find minimal elemement and order the array

int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}


PrintArray(arr);
SelectionSort(arr);

PrintArray(arr);