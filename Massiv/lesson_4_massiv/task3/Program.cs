﻿// Создать целочисленный массив на 10
// элементов и заполнить его произвольными
// числами. Вывести на экран чётные элементы
// массива.

int n = 10;
int[] array = { 1, 5, 9, 7, 6, 3, 4, 5, 2, 4, 3 };
int i = 0;

while (i < n) 
{
    if(array[i] % 2 ==0)
    {
        Console.Write($"{array[i]} ");
    }
    i = i + 1;
}