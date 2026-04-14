Console.WriteLine("Калькулятор чаевых");
Console.Write("Введите сумму счёта (руб): ");
double bill = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите процент чаевых: ");
double tipPercent = Convert.ToDouble(Console.ReadLine());

double tipAmount = bill * (tipPercent / 100);
double totalAmount = bill + tipAmount;

Console.WriteLine($"\nСумма счёта: {bill} руб");
Console.WriteLine($"Чаевые ({tipPercent}%): {tipAmount} руб");
Console.WriteLine($"Итого к оплате: {totalAmount} руб");