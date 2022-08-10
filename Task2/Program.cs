//Подсматривал в нете. 
//Строка — это последовательная коллекция символов,
//         которая используется для представления текста.
//Получается, что строку можно "использовать как массив"?
//По данному примеру я понял так. Это правильно?

Console.Clear();

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string num = Convert.ToString(number);

if (num.Length > 2)
{
  Console.WriteLine("третья цифра: " + num[2]);
}
else 
{
  Console.WriteLine("третьей цифры нет.");
}