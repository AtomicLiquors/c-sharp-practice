using System;

class Car
{
    public string brand;
    public string model;
    public int year;

    public void DisplayInfo()
    {
        Console.WriteLine("Brand: " + brand);
        Console.WriteLine("Model: " + model);
        Console.WriteLine("Year: " + year);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Car car1 = new Car();
        car1.brand = "Toyota";
        car1.model = "Corolla";
        car1.year = 2020;

        Car car2 = new Car();
        car2.brand = "Ford";
        car2.model = "Mustang";
        car2.year = 2023;

        Console.WriteLine("Car 1 Information:");
        car1.DisplayInfo();

        Console.WriteLine("\nCar 2 Information:");
        car2.DisplayInfo();
    }
}
