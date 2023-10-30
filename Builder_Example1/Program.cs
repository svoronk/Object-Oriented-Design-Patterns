using System;
using System.Collections.Generic;

// Product
class Pizza
{
    public List<string> Toppings { get; set; }
    public string Crust { get; set; }
    public string Size { get; set; }

    public void Display()
    {
        Console.WriteLine($"Custom Pizza: Size - {Size}, Crust - {Crust}");
        Console.WriteLine("Toppings: " + string.Join(", ", Toppings));
    }
}

// Builder
interface IPizzaBuilder
{
    IPizzaBuilder SetSize(string size);
    IPizzaBuilder SetCrust(string crust);
    IPizzaBuilder AddTopping(string topping);
    Pizza Build();
}

// Concrete Builder
class CustomPizzaBuilder : IPizzaBuilder
{
    private Pizza pizza = new Pizza();

    public IPizzaBuilder SetSize(string size)
    {
        pizza.Size = size;
        return this;
    }

    public IPizzaBuilder SetCrust(string crust)
    {
        pizza.Crust = crust;
        return this;
    }

    public IPizzaBuilder AddTopping(string topping)
    {
        if (pizza.Toppings == null)
        {
            pizza.Toppings = new List<string>();
        }
        pizza.Toppings.Add(topping);
        return this;
    }

    public Pizza Build()
    {
        return pizza;
    }
}

// Director
class PizzaMaker
{
    private IPizzaBuilder builder;

    public PizzaMaker(IPizzaBuilder pizzaBuilder)
    {
        builder = pizzaBuilder;
    }

    public Pizza BuildPizza()
    {
        return builder
            .SetSize("Large")
            .SetCrust("Thin")
            .AddTopping("Cheese")
            .AddTopping("Mushrooms")
            .AddTopping("Pepperoni")
            .Build();
    }
}

class Program
{
    static void Main()
    {
        IPizzaBuilder customBuilder = new CustomPizzaBuilder();
        PizzaMaker pizzaMaker = new PizzaMaker(customBuilder);
        Pizza customPizza = pizzaMaker.BuildPizza();
        customPizza.Display();
    }
}
