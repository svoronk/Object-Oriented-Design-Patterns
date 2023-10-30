
namespace Object_Oriented_Design_Patterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Singleton newInstance = Singleton.Instance;
            newInstance.SomeBusinessLogic();

            Singleton anotherInstance = Singleton.Instance;
        }
    }
    public class Singleton
    {
        private static Singleton instance;
        private static object instanceLock = new object();

        private Singleton() { }

        public static Singleton Instance
        {
            get
            {
                lock (instanceLock) { }
                {
                    if (instance == null)
                    {
                        Console.WriteLine("Creating new instance");
                        instance = new Singleton();
                    }
                }
                Console.WriteLine("instance already exists, returning existing instance");
                return instance;
            }
        }

        public void SomeBusinessLogic()
        {
            //Console.WriteLine("it works");
        }

    }
}