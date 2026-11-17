namespace Module1;

class Car : Transport
{
    private double _maxDistance;
    public double GetMaxDistance => _maxDistance;
    public Car(int ID) : base(ID) 
    {
        _baseCost = 50;
        _costPerKilo = 1;
        _costPerKm = 8;
        _type = "car";
        _maxWeight = 120;
    }
       

    public override double CalculateCost(Order order) 
    {
        return GetBaseCost + GetCostPerKm*order.GetDistance + GetCostPerKilo*order.GetWeight;
    }
}