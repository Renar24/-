// Автор: Кочетков Михаил 
// 1. Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку: 

Console.WriteLine("Заполните данные для составления анкеты");

Console.WriteLine("Ваше имя ? ");

string name = Console.ReadLine ();

Console.WriteLine("Ваша фамилия?"); 
string surname = Console.ReadLine(); 

Console.WriteLine("Ваш возраст?"); 
string age = Console.ReadLine(); 

Console.WriteLine("Ваш рост ?"); 
string Growth = Console.ReadLine(); 

Console.WriteLine("Ваш вес?"); 
string weight = Console.ReadLine(); 

Console.WriteLine(name + " " + surname + ": " + age + " лет, " + Growth + " см., " + weight + " кг.");
Console.WriteLine("{0} {1}: {2} лет, {3} см., {4} кг.", name, surname, age, weight);