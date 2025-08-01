using System;

interface IMovable
{
    void Move();
}

class Car : IMovable
{
    public void Move()
    {
        Console.WriteLine("Car is moving");
    }
}

class Bicycle : IMovable
{
    public void Move()
    {
        Console.WriteLine("Bicycle is moving");
    }
}

class Interface
{
    static void Main(string[] args)
    {
        IMovable lamborghini = new Car();
        IMovable electric_Bicycle = new Bicycle();

        lamborghini.Move();      
        electric_Bicycle.Move();  
    }
}
