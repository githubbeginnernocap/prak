using System;

class Автомобиль
{
    private string name;
    private int maxSpeed;

    public Автомобиль(string _name)
    {
        name = _name;
    }

    public void ShowInfo()
    {
        Console.WriteLine("Название автомобиля: " + name);
        Console.WriteLine("Максимальная скорость: " + maxSpeed);
    }

    public void SetMaxSpeed(int speed)
    {
        maxSpeed = speed;
    }
}

class Program
{
    static void Main(string[] args)
    {

        Автомобиль машина1 = new Автомобиль("Audi");
        Автомобиль машина2 = new Автомобиль("BMW");
        Автомобиль машина3 = new Автомобиль("Mercedes");
        Автомобиль машина4 = new Автомобиль("Tesla");


        машина1.SetMaxSpeed(250);
        машина2.SetMaxSpeed(270);
        машина3.SetMaxSpeed(280);
        машина4.SetMaxSpeed(300);

        машина1.ShowInfo();
        машина2.ShowInfo();
        машина3.ShowInfo();
        машина4.ShowInfo();


    }
}
