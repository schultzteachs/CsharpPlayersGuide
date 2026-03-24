int[] array = new int[] { 4, 51, -7, 13, 999, -99, 15, -8, 45, 90 };
int output = 0;
foreach (int num in array)
{
    if (num > output)
    {
        output = num; 
    }
    else
    {
        output = output;
    }
}

Console.WriteLine(string.Join(" ", array ));
Console.WriteLine($"The highest number is {output}");