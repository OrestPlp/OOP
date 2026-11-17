namespace Module1;

class Truck : Transport
{
    private double _maxDistance;
    public double GetMaxDistance => _maxDistance;
    public Truck(int ID) : base(ID) 
    {
        _baseCost = 200;
        _costPerKilo = 0.5;
        _costPerKm = 15;
        _type = "truck";
        _maxWeight = 2000;
    }
       

    public override double CalculateCost(Order order) 
    {
        return GetBaseCost + GetCostPerKm*order.GetDistance + GetCostPerKilo*order.GetWeight;
    }
}