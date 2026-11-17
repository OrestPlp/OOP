namespace Module1;

abstract class Transport
{
    protected bool _available;
    protected double _maxWeight;
    protected double _costPerKm;
    protected double _costPerKilo;
    protected double _baseCost;
    protected string _type;
    protected int _ID;
    public bool Available {get {return _available;} set{_available = value;}} 
    public double GetMaxWeight => _maxWeight;
    public double GetCostPerKm => _costPerKm;
    public double GetCostPerKilo => _costPerKilo;
    public double GetBaseCost => _baseCost;
    public string GetVehicleType => _type;
    public int GetID => _ID;

    public Transport(int ID)
    {
        _ID = ID;
        _available = true;
    }

    public abstract double CalculateCost(Order order);
    public virtual bool CanTake(Order order)
    {
        if(order.GetWeight > GetMaxWeight) return false;
        else return true;
    }
}