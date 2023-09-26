using System; 

public class Revers 
{
    public void Revers_stroki(string s) 
    {
        char[] arr = s.ToCharArray(); // Преобразование строки в массив символов
        Array.Reverse(arr); // Реверсирование массива символов
        Console.WriteLine("Строка в обратном порядке: " + new string(arr)); // Вывод результата в консоль
    }

    public void vivod_Revers_stroki() 
    {
        Console.Write("Введите строку: "); 
        string str = Console.ReadLine(); // Запрос ввода у пользователя строки 
        Revers_stroki(str); // Вызов метода Revers_stroki с одним аргументом
    }

    static void Main() 
    {
        Revers revers = new Revers(); // Создание объекта класса Revers
        revers.vivod_Revers_stroki(); // Вызов метода vivod_Revers_stroki для объекта revers
    }
}
