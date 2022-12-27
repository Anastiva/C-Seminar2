Console.Write("Введите трехзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(a);

if (a >= 100 && a < 1000)
{
    Console.WriteLine("Вторая цифра введенного числа: " + stringNumber[1]);
}
else
{
    Console.WriteLine("Число не трехзначное");
}