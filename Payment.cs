namespace Module1;

class PayCash : IPayment
{
    public void Pay(Order order, Transport vehicle) => Console.WriteLine($"До сплати готівкою {vehicle.CalculateCost(order)} грн.");
}

class PayCard : IPayment
{
    public void Pay(Order order, Transport vehicle) => Console.WriteLine($"До сплати карткою {vehicle.CalculateCost(order)} грн.");
}