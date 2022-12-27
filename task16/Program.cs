Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a == b * b || b == a * a)
{
    Console.Write("Одно число является квадратом другого");
}
else
{
    Console.Write("Числа не являются квадратами друг друга");
}