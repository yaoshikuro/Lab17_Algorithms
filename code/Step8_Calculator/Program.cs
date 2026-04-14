using System.Runtime.Serialization;
Console.WriteLine("Калькулятор");
Console.Write("Введите первое число: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите операцию которую хотите сделать: ");
string op = Console.ReadLine();

Console.Write("Введите второе число: ");
int y = Convert.ToInt32(Console.ReadLine());

if (op == "+")
{
    Console.WriteLine($"Сумма: {Sum(x, y)}");
}
else if (op == "-")
{
    Console.WriteLine($"Разность: {Subtract(x, y)}");
}
else if (op == "*")
{
    Console.WriteLine($"Произведение: {Multiply(x, y)}");
}
else if (op == "/")
{
    Console.WriteLine($"Частное: {Divide(x, y):F2}");
}
else
{
    Console.WriteLine($"пиши правильно болван");
}