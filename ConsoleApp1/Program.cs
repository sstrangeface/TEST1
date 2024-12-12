using System;

public class BANK
{
    static int balance = 3500;
    static int psswd = 1234;

    static void Main()
    {
        Console.WriteLine("Добро пожаловать в банкомат!");

        int vvodpsswd = 3;
        while (vvodpsswd > 0)
        {
            Console.Write("Введите пароль: ");
            int entpsswd = int.Parse(Console.ReadLine());

            if (entpsswd == psswd)
            {
                bool exit = false;
                while (!exit)
                {
                    Console.WriteLine("\nВыберите операцию:");
                    Console.WriteLine("1. Показать баланс");
                    Console.WriteLine("2. Снять деньги");
                    Console.WriteLine("3. Выход");

                    Console.Write("Ваш выбор: ");
                    int vybor = int.Parse(Console.ReadLine());

                    switch (vybor)
                    {
                        case 1:
                            pokazbalans();
                            break;
                        case 2:
                            vyvoddeneg();
                            break;
                        case 3:
                            exit = true;
                            Console.WriteLine("Спасибо за использование банкомата. До свидания!");
                            break;
                        default:
                            Console.WriteLine("Неверный выбор. Пожалуйста, попробуйте снова.");
                            break;
                    }
                }
                return;
            }
            else
            {
                vvodpsswd--;
                if (vvodpsswd > 0)
                {
                    Console.WriteLine($"Неверный пароль. Осталось попыток: {vvodpsswd}.");
                }
                else
                {
                    Console.WriteLine("Все попытки исчерпаны. Доступ запрещен.");
                }
            }
        }
    }

    static void pokazbalans()
    {
        Console.WriteLine($"Ваш баланс: {balance} рублей.");
    }

    static void vyvoddeneg()
    {
        Console.Write("Введите сумму для снятия: ");
        int summa = int.Parse(Console.ReadLine());

        if (summa <= balance)
        {
            balance -= summa;
            Console.WriteLine($"Вы сняли {summa} рублей. Ваш новый баланс: {balance} рублей.");
        }
        else
        {
            Console.WriteLine("Недостаточно средств на счете.");
        }
    }
}