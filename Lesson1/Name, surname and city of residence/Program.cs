// Автор: Кочетков Михаил 
//Написать программу, которая выводит на экран ваше имя, фамилию и город проживания 


using System;
					
public class Program
{
	public static void Main()
	{
		string name = "Kochetkov Mikhail";
		string city = "Krasnoyarsk";
		
		Console.SetCursorPosition(Console.WindowWidth / 3, Console.WindowHeight / 3);
		Console.WriteLine(name);
		Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
		Console.WriteLine(city);
	}
}