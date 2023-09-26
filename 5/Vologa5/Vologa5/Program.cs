using System; 

public class ProstoeChislo 
{
    public bool Proverka_Na_Prostoe_Chislo(int n) 
    {
        if (n < 1) // Проверка, является ли число положительным
            return false; // Возврат false, если число не положительное

        for (int i = 2; i * i <= n; i++) 
        {
            if (n % i == 0) // Проверка, делится ли число без остатка на текущее число
                return false; // Возврат false, если число делится без остатка
        }

        return true; // Возврат true, если число простое
    }

    public void vivod_Proverka_Na_Prostoe_Chislo() 
    {
        Console.Write("Введите число: "); 
        try // Начало блока обработки исключений
        {
            int number = Convert.ToInt32(Console.ReadLine()); //  Запрос ввода у пользователя ЦЭЛОГО числа 
            bool isPrime = Proverka_Na_Prostoe_Chislo(number); // Вызов метода Proverka_Na_Prostoe_Chislo с одним аргументом и сохранение результата в переменной isPrime
            if (isPrime) // Проверка, является ли число простым
            {
                Console.WriteLine("Число " + number + " является простым."); // Вывод сообщения о том, что число простое
            }
            else
            {
                Console.WriteLine("Число " + number + " не является простым."); // Вывод сообщения о том, что число не простое
            }
        }
        catch (FormatException) // Обработка исключения неправильного формата ввода
        {
            Console.WriteLine("Введено нецелое число или строка. Пожалуйста, введите целое число."); // Вывод сообщения об ошибке
        }
    }

    static void Main() 
    {
        ProstoeChislo prostoeChislo = new ProstoeChislo(); // Создание объекта класса ProstoeChislo
        prostoeChislo.vivod_Proverka_Na_Prostoe_Chislo(); // Вызов метода vivod_Proverka_Na_Prostoe_Chislo для объекта prostoeChislo
    }
}
