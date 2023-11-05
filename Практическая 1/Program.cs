using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Автомобиль
{
    private string Название;
    private int МаксимальнаяСкорость;

    public Автомобиль(string название, int максимальнаяСкорость)
    {
        Название = название;
        МаксимальнаяСкорость = максимальнаяСкорость;
    }

    public void ВывестиИнформацию()
    {
        Console.WriteLine($"Название автомобиля: {Название}");
        Console.WriteLine($"Максимальная скорость: {МаксимальнаяСкорость} км/ч");
    }
}

class Program
{
    static void Main(string[] args)
    {

        Автомобиль автомобиль1 = new Автомобиль("LADA", 350);
        Автомобиль автомобиль2 = new Автомобиль("Toyota", 320);
        Автомобиль автомобиль3 = new Автомобиль("SKODA", 310);
        Автомобиль автомобиль4 = new Автомобиль("BMW", 300);

        Console.WriteLine("Информация о гоночных автомобилях:");
        автомобиль1.ВывестиИнформацию();
        Console.WriteLine();
        автомобиль2.ВывестиИнформацию();
        Console.WriteLine();
        автомобиль3.ВывестиИнформацию();
        Console.WriteLine();
        автомобиль4.ВывестиИнформацию();

        Console.ReadLine();
    }
}
