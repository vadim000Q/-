using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("1. Решение квадратного уравнения");
        Console.Write("Введите коэффициент a: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Введите коэффициент b: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Введите коэффициент c: ");
        double c = double.Parse(Console.ReadLine());

        double discriminant = b * b - 4 * a * c;
        if (discriminant > 0)
        {
            double root1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
            double root2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            Console.WriteLine($"Корни уравнения: {root1} и {root2}");
        }
        else if (discriminant == 0)
        {
            double root = -b / (2 * a);
            Console.WriteLine($"Уравнение имеет один корень: {root}");
        }
        else
        {
            Console.WriteLine("Уравнение не имеет действительных корней.");
        }

        Console.WriteLine("\n2. Работа с числом \"p\"");
        int p = 0;
        while (true)
        {
            Console.Write("Введите число (для выхода введите любое число, отличное от текущего + 1): ");
            int userInput = int.Parse(Console.ReadLine());
            if (userInput == p + 1)
            {
                p = userInput;
                Console.WriteLine($"Текущее значение p: {p}");
            }
            else
            {
                p = 0;
                Console.WriteLine("Введено неправильное число. Начните заново.");
            }

            Console.Write("Хотите ли вы продолжить с шифрованием текста (да/нет)? ");
            string continueEncryption = Console.ReadLine().ToLower();
            if (continueEncryption != "да")
            {
                break;
            }

            Console.WriteLine("\n3. Шифрование и расшифровка строки шифром Цезаря");
            Console.Write("Введите текст для шифрования: ");
            string text = Console.ReadLine();
            Console.Write("Введите сдвиг: ");
            int shift = int.Parse(Console.ReadLine());

            char[] characters = text.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = (char)(characters[i] + shift);
            }
            string encryptedText = new string(characters);
            Console.WriteLine($"Зашифрованный текст: {encryptedText}");

            characters = encryptedText.ToCharArray();
            for (int i = 0; i < characters.Length; i++)
            {
                characters[i] = (char)(characters[i] - shift);
            }
            string decryptedText = new string(characters);
            Console.WriteLine($"Расшифрованный текст: {decryptedText}");
        }
    }
}