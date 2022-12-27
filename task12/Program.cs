Console.Write("Введите число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a%b == 0)
{
    Console.Write("Второе число кратно первому");
}
else
{
    Console.Write("Второе число некратно первому; остаток: " + a % b);
}