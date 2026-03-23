using System;
using System.Threading.Tasks.Sources;
//Console.WriteLine("Give a number...");
//int test = Int32.Parse(Console.ReadLine());
//if ((test % 2) == 0) Console.WriteLine("Tick");
//if ((test % 2) != 0) Console.WriteLine("Tock");



//Watch Tower Challenge p 78

//ask for x and y
Console.WriteLine("What is x value");
int x = Int32.Parse(Console.ReadLine());
Console.WriteLine("What is y value");
int y = Int32.Parse(Console.ReadLine());

Console.Write("The enemy is: ");
if ((x < 0) && (y < 0)){
    Console.Write("SW");
}
if ((x < 0) && (y == 0)){
    Console.Write("W");
}
if ((x < 0) && (y > 0)){
    Console.Write("NW");
}
if ((x == 0) && (y < 0)){
    Console.Write("S");
}
if ((x == 0) && (y == 0)){
    Console.Write("!!!");
}
if ((x == 0) && (y > 0)){
    Console.Write("N");
}
if ((x > 0) && (y < 0)){
    Console.Write("SE");
}
if ((x > 0) && (y == 0)){
    Console.Write("E");
}
if ((x > 0) && (y > 0)){
    Console.Write("NE");
}
//



//Console.WriteLine("enter your test score now....");
//int score = Int32.Parse(Console.ReadLine());
//string textToDisplay = score > 70 ? "this happens if greater" : "this happens if less";
//Console.WriteLine(textToDisplay);