using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

interface IAnimal
{
    void Voice();
}

class Dog : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Гав!");
    }
}

class Cat : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Мяу!");
    }
}

class Owl : IAnimal
{
    public void Voice()
    {
        Console.WriteLine("Ух! Ух! Ух!");
    }
}

interface IHello
{
    void SayHello();
}

class EnglishHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hello!");
    }
}

class FrenchHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Bonjour!");
    }
}

class SpanishHello : IHello
{
    public void SayHello()
    {
        Console.WriteLine("Hola!");
    }
}

interface IFilter
{
    string Execute(string textLine);
}

class DigitFilter : IFilter
{
    public string Execute(string textLine)
    {
        return new string(textLine.Where(char.IsDigit).ToArray());
    }
}

class LetterFilter : IFilter
{
    public string Execute(string textLine)
    {
        return new string(textLine.Where(char.IsLetter).ToArray());
    }
}

interface IShape
{
    void Draw(int size);
}

class VerticalLine : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine("|");
        }
    }
}

class HorizontalLine : IShape
{
    public void Draw(int size)
    {
        Console.WriteLine(new string('-', size));
    }
}

class Square : IShape
{
    public void Draw(int size)
    {
        for (int i = 0; i < size; i++)
        {
            Console.WriteLine(new string('*', size));
        }
    }
}

class Program
{
    static void PetAnimal(IAnimal animal)
    {
        Console.WriteLine("Мы гладим зверюшку, а она нам говорит:");
        animal.Voice();
    }

    static void Main()
    {
        // Задание 1: Пример с животными
        List<IAnimal> myAnimals = new List<IAnimal>
        {
            new Dog(),
            new Cat(),
            new Owl(),
        };

        Console.WriteLine("Задание 1:");
        foreach (IAnimal animal in myAnimals)
        {
            PetAnimal(animal);
        }


        // Задание 2: Пример с приветствиями
        List<IHello> greetings = new List<IHello>
        {
            new EnglishHello(),
            new FrenchHello(),
            new SpanishHello(),
        };

        Console.WriteLine("\nЗадание 2:");
        foreach (IHello greeting in greetings)
        {
            greeting.SayHello();
        }

   

        // Задание 3: Пример с фильтрами
        DigitFilter digitFilter = new DigitFilter();
        LetterFilter letterFilter = new LetterFilter();

        string inputText = "Hello123World";

        Console.WriteLine("\nЗадание 3:");
        Console.WriteLine("Original Text: " + inputText);
        Console.WriteLine("Filtered Digits: " + digitFilter.Execute(inputText));
        Console.WriteLine("Filtered Letters: " + letterFilter.Execute(inputText));


        // Задание 4: Пример с фигурами
        List<IShape> shapes = new List<IShape>
        {
            new VerticalLine(),
            new HorizontalLine(),
            new Square(),
        };

        Console.WriteLine("\nЗадание 4:");
        foreach (IShape shape in shapes)
        {
            shape.Draw(5);
            Console.WriteLine();
        }

        Console.ReadKey(true);
    }
}


