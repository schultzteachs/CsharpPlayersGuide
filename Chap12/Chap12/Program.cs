Console.WriteLine("Input a number and press enter...");
int[] array1 = new int[5];
for  (int i = 0; i < array1.Length; i++)
{
    
    array1[i] = Int32.Parse(Console.ReadLine());
}

//Console.WriteLine(array1);
Console.WriteLine(string.Join(" ", array1));

int[] array2 =  new int[5];
for (int b = 0; b < array2.Length; b++)
{
    array2[b] = array1[b];
}
Console.WriteLine(string.Join(" ", array2));

foreach (int num in array1)
    Console.WriteLine(num);

