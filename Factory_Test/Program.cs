namespace Factory_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UIFactory factory = new WindowsUIFactory();
            Button windowsButton = factory.CreateButton();
            windowsButton.render();
        }
    }
    public abstract class Button
    {
        public abstract void render();
    }
    public abstract class Checkbox
    {
        public abstract void render();
    }
    public class MacButton : Button
    {
        public override void render()
        {
            throw new NotImplementedException();
        }
    }
    public class WindowsButton : Button
    {
        public override void render()
        {
            throw new NotImplementedException();
        }
    }
    public class WindowsCheckbox : Checkbox
    {
        public override void render()
        {
            throw new NotImplementedException();
        }
    }
    public class MacCheckbox : Checkbox
    {
        public override void render()
        {
            throw new NotImplementedException();
        }
    }
    public abstract class UIFactory
    {
        public abstract Button CreateButton();
        public abstract Checkbox CreateCheckbox();
    }
    public class WindowsUIFactory : UIFactory
    {
        public override Button CreateButton()
        {
            return new WindowsButton();
        }

        public override Checkbox CreateCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
    public class MacUIFactory : UIFactory
    {
        public override Button CreateButton()
        {
            return new MacButton();
        }

        public override Checkbox CreateCheckbox()
        {
            return new MacCheckbox();
        }
    }
}