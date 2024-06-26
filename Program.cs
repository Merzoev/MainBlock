﻿// Задача: Написать программу, которая из имеющегося массива строк формирует 
// новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];

for (int i = 0; i < n; i++)
{
    Console.Write($"Введите {i + 1} элемент массива: ");
    array[i] = Console.ReadLine();
}

string[] newArray = new string[n];
int newArrayIndex = 0;

for (int i = 0; i < n; i++)
{
    if (array[i].Length <= 3)
    {
        newArray[newArrayIndex] = array[i];
        newArrayIndex++;
    }
}

Console.Write("Новый массив: ");
for (int i = 0; i < newArrayIndex; i++)
{
    Console.Write($"{newArray[i]} ");
}