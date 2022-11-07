void PrintCubeTable (int number)
{
    int count = 1;
    while (count<=number)
    {
        Console.Write(Math.Pow(count,3)+" ");
        count++;
    }
}


Console.WriteLine("Please, enter your number");
bool text = Int32.TryParse(Console.ReadLine(), out int number);
if (text)
{
    PrintCubeTable(number);
}
else
{
    Console.Write("Uncorrect number!!!!");
}
