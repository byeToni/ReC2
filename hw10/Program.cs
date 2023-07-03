Console.Clear();
Console.Write("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
while (num < 100 || num > 999)
{
    Console.Write("числол не трехзначное повторите ввод: ");
    num = Convert.ToInt32(Console.ReadLine());
};

Console.Write($"Вторая цифра:  {num%100/10}");