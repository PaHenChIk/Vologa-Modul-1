using System; 
using System.Numerics; 

public class Vologa_Modul_1 
{
    static void Main() 
    {
        Faktorial faktorial = new Faktorial(); // Создание объекта класса Faktorial
        faktorial.vivod_vycslenie_factiriala(); // Вызов метода vivod_vycslenie_factiriala для объекта faktorial

        Summa summa = new Summa(); // Создание объекта класса Summa
        summa.vivod_vycslenie_summu(); // Вызов метода vivod_vycslenie_summu для объекта summa

        Revers revers = new Revers(); // Создание объекта класса Revers
        revers.vivod_Revers_stroki(); // Вызов метода vivod_Revers_stroki для объекта revers

        Massiv massiv = new Massiv(); // Создание объекта класса Massiv
        massiv.vivod_srednee_v_massive(); // Вызов метода vivod_srednee_v_massive для объекта massiv

        ProstoeChislo prostoeChislo = new ProstoeChislo(); // Создание объекта класса ProstoeChislo
        prostoeChislo.vivod_Proverka_Na_Prostoe_Chislo(); // Вызов метода vivod_Proverka_Na_Prostoe_Chislo для объекта prostoeChislo
    }
}
