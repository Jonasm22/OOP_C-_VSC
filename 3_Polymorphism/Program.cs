public interface IPayment
{
    // TODO: Declare a method ProcessPayment
    void ProcessPayment();

}

public class CreditCardPayment : IPayment
{
    public void ProcessPayment()
    {
        System.Console.WriteLine("Processing credit card payment");
    }


}

public class PayPalPayment : IPayment
{
    public void ProcessPayment()
    {
        System.Console.WriteLine("Processing PayPal payment");
    }
}

public class Exercise
{
    public void ProcessPayments()
    {
        // TODO: Create instances of CreditCardPayment and PayPalPayment, and call the ProcessPayment method on each
        IPayment paypalpayment = new PayPalPayment();
        IPayment crediCardPayment = new CreditCardPayment();
        paypalpayment.ProcessPayment();
        crediCardPayment.ProcessPayment();

    }
}