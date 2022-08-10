Console.Write("Введи цифру, обозначающую день недели: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num >= 1 & num <= 7)
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


// Это интернет:
// Вопрос есть... Я не понял как напечатать вертикальный /. 

// // void CheckingTheDayOfTheWeek (int dayNumber) {
// //   if (dayNumber == 6 || dayNumber == 7) {
// //   Console.WriteLine("(этот день выходной) -> да");
// //   }
// //   else if (dayNumber < 1 || dayNumber > 7) {
// //     Console.WriteLine("это вообще не день недели");
// //   }
// //   else Console.WriteLine("(этот день не выходной) -> нет");
// }


