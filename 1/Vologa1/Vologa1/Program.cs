using System; 
using System.Numerics; 

public class Faktorial 
{
    public void vycslenie_factiriala(int n)
    {
        BigInteger factorial = 1; // Инициализация переменной для факториала
        for (int i = 2; i <= n; i++) 
        {
            factorial *= i; // Умножение факториала на текущее число
        }
        Console.WriteLine("Факториал числа " + n + " равен " + factorial); // Вывод результата в консоль
    }

    public void vivod_vycslenie_factiriala() 
    {
        Console.Write("Введите число: "); 
        try // Начало блока обработки исключений
        {
            int number = Convert.ToInt32(Console.ReadLine()); // Запрос ввода у пользователя ЦЭЛОГО числа 
            vycslenie_factiriala(number); // Вызов метода vycslenie_factiriala с одним аргументом
        }
        catch (FormatException) // Обработка исключения неправильного формата ввода
        {
            Console.WriteLine("Введено нецелое число или строка. Пожалуйста, введите целое число."); // Вывод сообщения об ошибке
        }
    }

    static void Main() 
    {
        Faktorial faktorial = new Faktorial(); // Создание объекта класса Faktorial
        faktorial.vivod_vycslenie_factiriala(); // Вызов метода vivod_vycslenie_factiriala для объекта faktorial
    }
}
