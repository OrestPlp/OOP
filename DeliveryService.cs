namespace Module1;

class DeliveryService
{
    private int ID = 0;
    private List<Transport> _present_types = new List<Transport>();
    private List<Transport> _vehicleList = new List<Transport>();
    private List<Order> _activeOrders = new List<Order>();
    private List<Order> _orderHistory = new List<Order>();
    private int _transportID = 0;
    public List<Transport> VehicleList {get{return _vehicleList;} set{_vehicleList = value;}}
    public List<Order> ActiveOrders{get{return _activeOrders;} set{_activeOrders = value;}}
    public List<Order> OrderHistory{get{return _orderHistory;} set{_orderHistory = value;}}
    public void SetTypes()
    {
        _present_types.Clear();
        Car car0 = new Car(0);
        Truck truck0 = new Truck(0);
        Bike bike0 = new Bike(0);

        _present_types.Add(car0);
        _present_types.Add(truck0);
        _present_types.Add(bike0);
    }

    public void DisplayCost(Order order)
    {
        Console.WriteLine($"Вартість доставки замовлення '{order.GetDescription}':");
        int counter = 0;
        foreach(Transport type in _present_types)
        {
            if(type.CanTake(order))
            {
                Console.WriteLine($"{type.GetVehicleType} - {type.CalculateCost(order)} грн.");
                counter++;
            }      
        }
        if(counter == 0) Console.WriteLine("Жоден вид транспорту не може доставити це замовлення");
        Console.WriteLine();     
    }

    public void DisplayActiveOrders()
    {
        Console.WriteLine("Активні замовлення:");
        if(ActiveOrders.Count() == 0)
        {
            Console.WriteLine("Відсутні");
            return;
        }
        foreach(Order order in ActiveOrders)
        {
            Console.WriteLine($"""
            [ID: {order.GetID}; Опис: {order.GetDescription}]
            """);
        }
    }

    public void DisplayOrderHistory()
    {
        Console.WriteLine("Виконані замовлення:");
        if(OrderHistory.Count() == 0)
        {
            Console.WriteLine("Відсутні");
            return;
        }
        foreach(Order order in OrderHistory)
        {
            Console.WriteLine($"""
            [ID: {order.GetID}; Опис: {order.GetDescription}]
            """);
        }
    }

    
    
    public Order CreateOrder(string description, double weight, double distance)
    {
        Order order = new Order(ID, description, weight,distance);
        ID++;
        return order;
    }
    public void CreateCar()
    {
        Car car = new Car(_transportID); 
        _transportID ++;
        VehicleList.Add(car);    
    }

    public void CreateBike()
    {
        Bike bike = new Bike(_transportID);
        _transportID ++; 
        VehicleList.Add(bike);    
    }

    public void CreateTruck()
    {
        Truck truck = new Truck(_transportID); 
        _transportID ++;
        VehicleList.Add(truck);    
    }
    public void SimulateOrderCompletion(Order order)
    {
        foreach(Order chosen in ActiveOrders)
        {
            if(chosen == order)
            {
                foreach(Transport vehicle in VehicleList) 
                {if(vehicle.GetID == order.TransportID) vehicle.Available = true;}

                chosen.TransportID = -1;
                OrderHistory.Add(chosen); 
                ActiveOrders.Remove(chosen);         
                return;      
            }
        }
    }
    public void PayForOrder(IPayment method, Order order, Transport vehicle) => method.Pay(order, vehicle);
    public void TakeOrder(Order order, string type, IPayment method)
    {
        List<Transport> canTakeOrderAndAvailable = new List<Transport>();
        foreach(Transport vehicle in VehicleList)
        {
            if((vehicle.CanTake(order) == true) && (vehicle.Available == true)) canTakeOrderAndAvailable.Add(vehicle);
        }

        if(canTakeOrderAndAvailable.Count == 0) 
        {
            Console.WriteLine("Наразі нема транспорту щоб прийняти це замовлення.");
            return;
        }
        foreach(Transport vehicle in canTakeOrderAndAvailable)
        {
            if(vehicle.GetVehicleType == type)
            {
                PayForOrder(method, order, vehicle);
                vehicle.Available = false;
                order.TransportID = vehicle.GetID;
                ActiveOrders.Add(order);
                return;
            }
        }

        Console.WriteLine("Наразі нема транспорту щоб прийняти це замовлення.");
        return;
        
        
    }

}