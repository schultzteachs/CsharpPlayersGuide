using System;

int[] a1 = { 1, 2, 3, 4 } ;
int[] a2;

Console.WriteLine(string.Join(", ",a1));
  

a2 = a1 ;
Console.WriteLine("a2 is now set to a1. Below is a2 now");
Console.WriteLine(string.Join(", ",a2));

Console.WriteLine("Below is the comparison of a2 to a1");
Console.WriteLine(a2 == a1);

int[] a3 = { 1, 2, 3, 4 } ;
Console.WriteLine("Below is the comparison of a3 (which is { 1, 2, 3, 4 } to a1");
Console.WriteLine(a3 == a1);
Console.WriteLine("They are not equal because they are referencing two different data points. This is call reference semantics");

Console.WriteLine("a2[0] is changed to -1");
a2[0] = -1;
Console.WriteLine("Here is a1");
Console.WriteLine(string.Join(", ", a1));

//value types are usually stored in the stack and reference types on the heap

//in the example above, a1 and a2 are both reference types. When I set a2 to a1, the reference for the array is store in a2 (in the heap)
//since the two variables are referencing the same data, when I change a2[0] to -1, this also changes for a1
//the issue arises when comparing reference types, above the 