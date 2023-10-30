using System;

// Receiver
class Light
{
    public void TurnOn()
    {
        Console.WriteLine("Light is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Light is off");
    }
}

// Command Interface
interface ICommand
{
    void Execute();
}

// Concrete Command for Turning On Light
class TurnOnLightCommand : ICommand
{
    private Light light;

    public TurnOnLightCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOn();
    }
}

// Concrete Command for Turning Off Light
class TurnOffLightCommand : ICommand
{
    private Light light;

    public TurnOffLightCommand(Light light)
    {
        this.light = light;
    }

    public void Execute()
    {
        light.TurnOff();
    }
}

// Invoker (Remote Control)
class RemoteControl
{
    private ICommand command;

    public void SetCommand(ICommand command)
    {
        this.command = command;
    }

    public void PressButton()
    {
        command.Execute();
    }
}

class Program
{
    static void Main()
    {
        Light livingRoomLight = new Light();
        ICommand turnOnCommand = new TurnOnLightCommand(livingRoomLight);
        ICommand turnOffCommand = new TurnOffLightCommand(livingRoomLight);

        RemoteControl remote = new RemoteControl();

        remote.SetCommand(turnOnCommand);
        remote.PressButton(); // Turns on the light

        remote.SetCommand(turnOffCommand);
        remote.PressButton(); // Turns off the light
    }
}
