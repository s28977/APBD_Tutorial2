// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World 3!");

static double Average(int[] arr)
{
    double sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }

    return sum / arr.Length;
}
Console.WriteLine(Average([3, 5, 9, -2]));
