namespace Strategy_Example1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Payment paymentContext = new Payment(new CreditCardPayment());

            // Process payments using different strategies.
            paymentContext.ProcessPayment(100);

            // Change the payment strategy to Bitcoin.
            paymentContext.SetPaymentStrategy(new BitcoinPayment());
            paymentContext.ProcessPayment(300);
        }
        public interface IPaymentStrategy
        {
            void Pay(int amount);
        }
        public class CreditCardPayment : IPaymentStrategy
        {
            public void Pay(int amount)
            {
                throw new NotImplementedException();
            }
        }
        public class BitcoinPayment : IPaymentStrategy
        {
            public void Pay(int amount)
            {
                throw new NotImplementedException();
            }
        }
        public class Payment
        {
            public int amount;
            private IPaymentStrategy paymentStrategy;

            public Payment(IPaymentStrategy strategy)
            {
                paymentStrategy = strategy;
            }

            public void SetPaymentStrategy(IPaymentStrategy strategy)
            {
                paymentStrategy = strategy;
            }

            public void ProcessPayment(int amount)
            {
                paymentStrategy.Pay(amount);
            }
        }
    }
}