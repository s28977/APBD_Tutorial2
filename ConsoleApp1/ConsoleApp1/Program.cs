﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World 3!");

static double Average(int[] arr)
{
    double tmpSum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        tmpSum += arr[i];
    }

    return tmpSum / arr.Length;
}
Console.WriteLine(Average([3, 5, 9, -2]));

static int Max(int[] arr)
{
    int max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max)
        {
            max = arr[i];
        }
    }

    return max;
}
Console.WriteLine(Max([3, 5, 9, -2]));
