
using System;

class NumberManager
{
    private int n = 0;

    public bool SetNumber(int number)
    {
        if (number == n + 1)
        {
            n = number;
            return true;
        }
        else
        {
            n = 0;
            return false;
        }
    }

    public int GetExpectedNumber()
    {
        return n + 1;
    }
}

class Program
{
    static void Main()
    {
        NumberManager manager = new NumberManager();

        while (true)
        {
            int expectedNumber = manager.GetExpectedNumber();
            Console.Write("Введите число " + expectedNumber + ": ");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                if (manager.SetNumber(userInput))
                {
                    Console.WriteLine("Верно! Ожидается следующее число.");
                }
                else
                {
                    Console.WriteLine("Ошибка! Ожидается число " + expectedNumber + ". Начните сначала.");
                }
            }
            else
            {
                Console.WriteLine("Ошибка! Введите корректное целое число.");
            }
        }
    }
}