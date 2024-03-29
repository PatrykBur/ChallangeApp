﻿using System.Diagnostics.Metrics;
using static System.Runtime.InteropServices.JavaScript.JSType;
int number = 125457746;
int[] table = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

Console.WriteLine("wynik dla liczby " + number);
for (int i = 0; i < table.Length; i++)
{
    int numberofdigits = 0;
    int digits = table[i];
    int digitPosition = number.ToString().IndexOf(digits.ToString());

    while (digitPosition != -1)
    {
        numberofdigits++;
        digitPosition = number.ToString().IndexOf(digits.ToString(), digitPosition + 1);
    }
    Console.WriteLine(table[i] + "->" + numberofdigits);
}
