﻿

Human one = new Human("Иринка", "Заречнева", 35);
Human two = new Human("Ленчик", "Шалаева", 30);
Human three = new Human("Ольга", "Минина", 32);
Human four = new Human("Катя", "Усикова", 31);
Human five = new Human("Ольга", "Еременко", 42);
Human six = new Human("Катя", "Солдатова", 40);
Human seven = new Human("Юльчик", "Иванова", 35);
List<Human> list = new List<Human>()
{
    one, two, three, four,
    five, seven
};
foreach (var item in list)
{
    Console.WriteLine(item);
}
Console.WriteLine("Введите возраст:");
int year=Convert.ToInt32( Console.ReadLine());

List<Human> FoundYear = list.FindAll(item => item._age <= year);
List<Human> Age_Year = new List<Human>();

foreach (var item in FoundYear)
{ 
    Console.WriteLine($"Возраст {item._age} совпадает с Имя: {item._name}\t\t Фамилия: {item._surname}") ; 
}