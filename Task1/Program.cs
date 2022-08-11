Console.Clear();

Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num > 99 && num < 1000)
{
    int Number = (num % 100) / 10;
    Console.WriteLine("Вторая цифра " +Number + ".");
}
else
{
    Console.WriteLine("Введите ТРЁХЗНАЧНОЕ число. Попробуйте ещё раз.");
}    
