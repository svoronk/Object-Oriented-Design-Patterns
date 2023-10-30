using System;

// Implementation
interface IDevice
{
    void TurnOn();
    void TurnOff();
    void SetChannel(int channel);
}

// Concrete Implementations
class TV : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("TV is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("TV is off");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine("TV channel is set to " + channel);
    }
}

class Radio : IDevice
{
    public void TurnOn()
    {
        Console.WriteLine("Radio is on");
    }

    public void TurnOff()
    {
        Console.WriteLine("Radio is off");
    }

    public void SetChannel(int channel)
    {
        Console.WriteLine("Radio channel is set to " + channel);
    }
}

// Abstraction
class RemoteControl
{
    protected IDevice device;

    public RemoteControl(IDevice device)
    {
        this.device = device;
    }

    public virtual void TurnOn()
    {
        device.TurnOn();
    }

    public virtual void TurnOff()
    {
        device.TurnOff();
    }

    public virtual void SetChannel(int channel)
    {
        device.SetChannel(channel);
    }
}

// Refined Abstraction
class AdvancedRemoteControl : RemoteControl
{
    public AdvancedRemoteControl(IDevice device) : base(device) { }

    public void Mute()
    {
        Console.WriteLine("Sound is muted");
    }
}

class Program
{
    static void Main()
    {
        IDevice tvDevice = new TV();
        IDevice radioDevice = new Radio();

        RemoteControl tvRemote = new RemoteControl(tvDevice);
        RemoteControl radioRemote = new RemoteControl(radioDevice);

        tvRemote.TurnOn();
        tvRemote.SetChannel(5);
        tvRemote.TurnOff();

        radioRemote.TurnOn();
        radioRemote.SetChannel(102.5);
        radioRemote.TurnOff();

        AdvancedRemoteControl advancedRemote = new AdvancedRemoteControl(tvDevice);
        advancedRemote.TurnOn();
        advancedRemote.SetChannel(8);
        advancedRemote.Mute();
        advancedRemote.TurnOff();
    }
}
