using System; 

public class Massiv 
{
    public void srednee_v_massive() 
    {
        Random rand = new Random(); // Создание объекта класса Random
        int[] arr = new int[15]; // Создание массива из 15 элементов
        int sum = 0; // Инициализация переменной для суммы положительных чисел
        int count = 0; // Инициализация счетчика положительных чисел

        for (int i = 0; i < arr.Length; i++) // Цикл по элементам массива
        {
            arr[i] = rand.Next(-50, 50); // Присвоение элементу массива случайного числа от -50 до 50
            Console.Write(arr[i] + " "); // Вывод элементов массива на консоль
            if (arr[i] > 0) // Проверка, является ли число положительным
            {
                sum += arr[i]; // Добавление числа к сумме
                count++; // Увеличение счетчика на 1
            }
        }

        if (count > 0) // Проверка, есть ли в массиве положительные числа
        {
            double average = (double)sum / count; // Вычисление среднего значения положительных чисел
            Console.WriteLine("\nСреднее значение положительных чисел в массиве: " + average); // Вывод результата в консоль
        }
        else
        {
            Console.WriteLine("\nВ массиве нет положительных чисел."); // Вывод сообщения об отсутствии положительных чисел в массиве
        }
    }

    public void vivod_srednee_v_massive() 
    {
        srednee_v_massive(); // Вызов метода srednee_v_massive
        Console.WriteLine("Нажмите любую клавишу для продолжения..."); // Вывод сообщения о продолжении работы программы
        Console.ReadKey(); // Чтение символа из консоли для продолжения работы программы
    }

    static void Main() 
    {
        Massiv massiv = new Massiv(); // Создание объекта класса Massiv
        massiv.vivod_srednee_v_massive(); // Вызов метода vivod_srednee_v_massive для объекта massiv
    }
}
