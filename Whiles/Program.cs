﻿// Вывод таблицы умножения на экран
for(int i = 2; i <= 10; i++)
{
    for (int j = 1; j <= 10; j++)
    {
        Console.WriteLine($"{i}*{j} = {i*j}"); // Интерполяция строк
    }
     Console.WriteLine(); //Переход на новую строку (разрыв)
}