bool Palindrome (int number)
{
    int reverse_num = 0;
    int front_num = number;
    while (number>0)
    {
        reverse_num = reverse_num*10 + number%10;
        number = number/10;
    }
    if (reverse_num==front_num)
    {
        return true;
    }
    else
    {
        return false;
    }

}

Console.Clear();
Console.WriteLine("Пожалуйста, введите Ваше число!");
bool text = Int32.TryParse(Console.ReadLine(), out int number);
if (text)
{
    if (Palindrome(number))
    {
        Console.WriteLine($"Число {number} является палиндромом");
    }
    else
    {
        Console.WriteLine($"Число {number} не является палиндромом");
    }
}
else
{
    Console.WriteLine("Введенный текст не является числом!!!");
}