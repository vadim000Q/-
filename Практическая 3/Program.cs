using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class SmsMessage
{
    private string messageText;
    private double price;

    public string MessageText
    {
        get { return messageText; }
        set
        {
            if (value.Length <= 65)
            {
                price = 1.5;
            }
            else if (value.Length > 65 && value.Length <= 250)
            {
                price = 1.5 + 0.5 * (value.Length - 65);
            }
            else
            {
                price = 1.5 + 0.5 * (250 - 65);
            }
            messageText = value.Length > 250 ? value.Substring(0, 250) : value;
        }
    }

    public double Price
    {
        get { return price; }
    }
}

class SQLCommand
{
    private string commandText;

    public string CommandText
    {
        get { return commandText; }
        set { commandText = value.ToUpper(); }
    }
}

class MyIntList
{
    private List<int> list = new List<int>();

    public void Add(int item)
    {
        list.Add(item);
    }

    public int Count
    {
        get { return list.Count; }
    }
}

class RandomNumberGenerator
{
    private Random random = new Random();

    public List<int> GenerateRandomNumbers(int count, int min, int max)
    {
        List<int> numbers = new List<int>();
        for (int i = 0; i < count; i++)
        {
            numbers.Add(random.Next(min, max + 1));
        }
        return numbers;
    }
}

class Program
{
    static void Main(string[] args)
    {
        // 1. Пример использования класса SmsMessage
        SmsMessage sms = new SmsMessage();
        sms.MessageText = "Пример текста SMS сообщения длиной более 65 символов.";
        Console.WriteLine($"Текст сообщения: {sms.MessageText}");
        Console.WriteLine($"Стоимость сообщения: {sms.Price} руб.");

        // 2. Пример использования класса SQLCommand
        SQLCommand sqlCommand = new SQLCommand();
        sqlCommand.CommandText = "select * from users where id = 1;";
        Console.WriteLine($"SQL запрос: {sqlCommand.CommandText}");

        // 3. Пример использования класса MyIntList
        MyIntList intList = new MyIntList();
        intList.Add(1);
        intList.Add(2);
        intList.Add(3);
        Console.WriteLine($"Количество элементов в списке: {intList.Count}");

        // 4. Пример использования класса RandomNumberGenerator
        RandomNumberGenerator rng = new RandomNumberGenerator();
        List<int> randomNumbers = rng.GenerateRandomNumbers(5, 1, 100);
        Console.WriteLine("Сгенерированные случайные числа:");
        foreach (var number in randomNumbers)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
        Console.ReadLine();

        // 5. Пример использования конструкторов и метода DisplayColor класса Color
        Color color1 = new Color(255, 0, 0); // Красный
        Color color2 = new Color(); // Конструктор без параметров
        color2.SetGreen(255); // Установка значения зеленого цвета
        color2.SetBlue(255); // Установка значения синего цвета
        color1.DisplayColor();
        color2.DisplayColor();
    }
}

class Color
{
    private int red;
    private int green;
    private int blue;

    public Color() { }

    public Color(int red, int green, int blue)
    {
        SetRed(red);
        SetGreen(green);
        SetBlue(blue);
    }

    private int NormalizeColorValue(int colorValue)
    {
        if (colorValue > 255)
        {
            return 255;
        }
        if (colorValue < 0)
        {
            return 0;
        }
        return colorValue;
    }

    public void SetRed(int red)
    {
        this.red = NormalizeColorValue(red);
    }

    public void SetGreen(int green)
    {
        this.green = NormalizeColorValue(green);
    }

    public void SetBlue(int blue)
    {
        this.blue = NormalizeColorValue(blue);
    }

    public void DisplayColor()
    {
        Console.WriteLine($"Цвет: R={red}, G={green}, B={blue}");
    }
}