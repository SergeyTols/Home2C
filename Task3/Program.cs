Console.Write("Введи цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 1 && num <= 7)
{
    if(num < 6)
    {
         Console.Write("Рабочий");
    }
    else
    {
        Console.Write("Выходной");
    }
}
else
{
    Console.Write("Сбегай к старшим, уточни, сколько дней в неделе!");
}
