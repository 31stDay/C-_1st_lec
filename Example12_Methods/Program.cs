// 1st type - accept nothing and return nothing 
void Method1()
{
    Console.WriteLine("The author is Chernyshova Dina");
}
Method1();

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

//3rd type - accept nothing and return something
int Method3()
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

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