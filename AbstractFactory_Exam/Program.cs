namespace AbstractFactory_Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FurnitureFactory plasticFactory = new PlasticFurnitureFactory();
            Chair newChair = plasticFactory.getChair();
            newChair.CreateChair();
        }
    }
    public abstract class FurnitureFactory
    {
        public abstract Table getTable();
        public abstract Chair getChair();
    }
    public class PlasticFurnitureFactory : FurnitureFactory
    {
        public override Chair getChair()
        {
            return new PlasticChair();
        }

        public override Table getTable()
        {
            return new PlasticTable();
        }
    }
    public class WoodenFurnitureFactory : FurnitureFactory
    {
        public override Chair getChair()
        {
            return new WoodenChair();
        }

        public override Table getTable()
        {
            return new WoodenTable();
        }
    }
    public class PlasticChair : Chair
    {
        public override void CreateChair()
        {
            Console.WriteLine("Created Plastic Chair");
        }
    }
    public class PlasticTable : Table
    {
        public override void CreateTable()
        {
            Console.WriteLine("Created Plastic Table");
        }
    }
    public class WoodenChair : Chair
    {
        public override void CreateChair()
        {
            Console.WriteLine("Created Wooden Chair");
        }
    }
    public class WoodenTable : Table
    {
        public override void CreateTable()
        {
            Console.WriteLine("Created Wooden Table");
        }
    }
    public abstract class Table
    {
        public abstract void CreateTable();
    }
    public abstract class Chair
    {
        public abstract void CreateChair();
    }
}