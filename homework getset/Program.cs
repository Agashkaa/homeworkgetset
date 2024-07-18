using System;

// Абстрактный класс Animal
public abstract class Animal
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public abstract void Eat();
}

// Класс Dog, наследующий от Animal
public class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("The dog is eating.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Запросить у пользователя имя собаки
        Console.Write("Enter the name of the dog: ");
        string dogName = Console.ReadLine();

        // Создать объект Dog и задать ему имя
        Dog myDog = new Dog();
        myDog.SetName(dogName);

        // Вывести имя собаки и вызвать метод Eat
        Console.WriteLine("The dog's name is: " + myDog.GetName());
        myDog.Eat();
    }
}