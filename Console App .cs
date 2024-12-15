using System;

namespace ATMConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal balance = 1000.00m; // Начальный баланс
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("1. Показать баланс\n2. Снять деньги\n3. Выход");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        Console.WriteLine($"Ваш баланс: {balance:C}");
                        break;
                    case "2":
                        Console.Write("Введите сумму для снятия: ");
                        if (decimal.TryParse(Console.ReadLine(), out decimal amount) && amount > 0 && amount <= balance)
                        {
                            balance -= amount;
                            Console.WriteLine($"Вы сняли: {amount:C}. Новый баланс: {balance:C}");
                        }
                        else
                        {
                            Console.WriteLine("Некорректная сумма или недостаточно средств.");
                        }
                        break;
                    case "3":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Некорректный выбор. Попробуйте снова.");
                        break;
                }
            }
        }
    }
}