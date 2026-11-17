
namespace Module1;

class Bike : Transport
{
    private double _maxDistance;
    public double GetMaxDistance => _maxDistance;
    public Bike(int ID) : base(ID)
    {
        _maxDistance = 10;
        _baseCost = 20;
        _costPerKilo = 5;
        _type = "bike";
        _maxWeight = 10;
    }
       

    public override double CalculateCost(Order order) 
    {
        return GetBaseCost + GetCostPerKm*order.GetDistance;
    }

    public override bool CanTake(Order order)
    {
        if((order.GetWeight > GetMaxWeight) || (order.GetDistance > _maxDistance)) return false;
        else return true;
    }
}