using System;

// Product
class Car
{
    public string Model { get; set; }
    public string Engine { get; set; }
    public string Transmission { get; set; }
    public bool HasNavigation { get; set; }

    public void Display()
    {
        Console.WriteLine($"Car Model: {Model}");
        Console.WriteLine($"Engine: {Engine}");
        Console.WriteLine($"Transmission: {Transmission}");
        Console.WriteLine($"Navigation System: {(HasNavigation ? "Yes" : "No")}");
    }
}

// Builder
interface ICarBuilder
{
    void SetModel(string model);
    void SetEngine(string engine);
    void SetTransmission(string transmission);
    void AddNavigation();
    Car GetCar();
}

// Concrete Builder
class CustomCarBuilder : ICarBuilder
{
    private Car car = new Car();

    public void SetModel(string model)
    {
        car.Model = model;
    }

    public void SetEngine(string engine)
    {
        car.Engine = engine;
    }

    public void SetTransmission(string transmission)
    {
        car.Transmission = transmission;
    }

    public void AddNavigation()
    {
        car.HasNavigation = true;
    }

    public Car GetCar()
    {
        return car;
    }
}

// Director
class CarManufacturer
{
    private ICarBuilder builder;

    public CarManufacturer(ICarBuilder carBuilder)
    {
        builder = carBuilder;
    }

    public Car BuildCar()
    {
        builder.SetModel("Sedan");
        builder.SetEngine("V6");
        builder.SetTransmission("Automatic");
        builder.AddNavigation();
        return builder.GetCar();
    }
}

class Program
{
    static void Main()
    {
        ICarBuilder customCarBuilder = new CustomCarBuilder();
        CarManufacturer carManufacturer = new CarManufacturer(customCarBuilder);
        Car customCar = carManufacturer.BuildCar();
        customCar.Display();
    }
}
