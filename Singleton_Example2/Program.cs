namespace Singleton_Example2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public class Signletonclass
    {
        private static Signletonclass instance;
        private static object _lock = new object();
        private Signletonclass(){ }

        public static Signletonclass Instance
        {
            get
            {
                if (instance == null)
                {
                    lock(_lock)
                    {
                        instance = new Signletonclass();
                    }
                }
                return instance;
            }
        }
        public void getPerson()
        {

        }
    }
}