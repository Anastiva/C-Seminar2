Console.Write("Введите число: ");
int a = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(a);

if(a >= 100)
{
    Console.WriteLine("Третья цифра введенного числа: " + stringNumber[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}