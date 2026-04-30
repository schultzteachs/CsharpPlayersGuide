Console.WriteLine("What do you want me to tell you next time?");
string? message = Console.ReadLine();

File.WriteAllText("Message.txt", message);