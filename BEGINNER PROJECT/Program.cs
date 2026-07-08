using System.Threading.Channels;

Console.WriteLine("Hello!");
Console.WriteLine("[S]ee all TODOs");
Console.WriteLine("[A]dd a TODO");
Console.WriteLine("[R]emove a TODO");
Console.WriteLine("[E]xit");

String userChoice = Console.ReadLine();
Console.WriteLine("User input:" + userChoice);
userChoice = "ABC"; 

Console.ReadKey();