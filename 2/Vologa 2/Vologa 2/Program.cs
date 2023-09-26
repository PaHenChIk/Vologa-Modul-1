using System; 

public class Summa 
{
    public void vycslenie_summu(int a, int b) 
    {
        int sum = a + b; // Вычисление суммы двух чисел
        Console.WriteLine("Сумма чисел " + a + " и " + b + " равна " + sum); // Вывод результата в консоль
    }
    public void vivod_vycslenie_summu() 
    {
        try // Начало блока обработки исключений
        {
            Console.Write("Введите первое число: "); 
            int number1 = Convert.ToInt32(Console.ReadLine()); // Запрос ввода у пользователя первого ЦЭЛОГО числа 

            Console.Write("Введите второе число: "); 
            int number2 = Convert.ToInt32(Console.ReadLine()); // Запрос ввода у пользователя второго ЦЭЛОГО числа 

            vycslenie_summu(number1, number2); // Вызов метода vycslenie_summu с двумя аргументами
        }
        catch (FormatException) // Обработка исключения неправильного формата ввода
        {
            Console.WriteLine("Введено нецелое число или строка. Пожалуйста, введите целое число."); // Вывод сообщения об ошибке
        }
    }

    public static void Main() 
    {
        Summa summa = new Summa(); // Создание объекта класса Summa
        summa.vivod_vycslenie_summu(); // Вызов метода vivod_vycslenie_summu для объекта summa
    }
}
