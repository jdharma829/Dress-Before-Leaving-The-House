// See https://aka.ms/new-console-template for more information
using DressBeforeLeavingTheHouse;

Console.WriteLine("Please enter sequence:");

var input = Console.ReadLine();

Console.WriteLine(new DressingManager().Process(input));

Console.ReadKey();
