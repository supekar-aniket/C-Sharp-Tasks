abstract class Payment
{
    public abstract void Pay();
}

class UpiPayment : Payment
{
    public override void Pay()
    {
        System.Console.WriteLine($"UPI Payment processed successfully...!");
    }
}

class CardPayment : Payment
{
    public override void Pay()
    {
        System.Console.WriteLine($"Card Payment processed successfully...!");
    }
}

class CashPayment : Payment
{
    public override void Pay()
    {
        System.Console.WriteLine($"Cash Payment processed successfully...!");
    }
}

class Test
{
    public static void Main()
    {
        List<Payment> payments = new List<Payment>
        {
            new UpiPayment(),
            new CardPayment(),
            new CashPayment()
        };

        foreach (Payment payment in payments)
        {
            payment.Pay();
        }
    }
}