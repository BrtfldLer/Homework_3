// принимает число N и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("Введите целое положительное число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Ниже приведена таблица квадратов от 1 до {N}");
for (int i = 1; i < N+1; i++)
{
    Console.WriteLine($"{i}*{i}*{i} = {i*i*i}");
    if (i % 5 == 0)
    {
    Console.WriteLine();
    }
}
