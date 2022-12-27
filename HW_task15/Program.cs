Console.Write("Введите число: ");
int DayNumber = Convert.ToInt32(Console.ReadLine());

if (DayNumber == 6 || DayNumber == 7)
{
    Console.Write("Выходной день");
}
else if (DayNumber > 0 && DayNumber < 6)
{
    Console.Write("Будний день");
}
else
{
    Console.Write("Ошибка");
}