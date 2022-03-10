// принимает пятизначное число и проверяет на палиндром
Console.WriteLine("Введите пятизначное число");
int number = Convert.ToInt32(Console.ReadLine());
int numberABS = Math.Abs(number);
if ((numberABS < 10000) | (numberABS > 99999))
{
    Console.WriteLine("Ошибка ввода");
}
else
{
    string str1 = Convert.ToString(numberABS);
    int F = 0;
    for (int i = 0; i<1; i++)
    {
        if (str1.Substring(i, 1) != str1.Substring(4 - i, 1))
        {
            F = 1;
            break;
        }
    }
    if (F==0)
    {
        Console.WriteLine($"{number} - палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - не палиндром");
    }
}