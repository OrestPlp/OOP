 namespace Module1;
 class Order
    {
        private int _ID;
        private string _description;
        private double _weight;
        private double _distance;
        private  int _transportID;
        
        public double GetDistance => _distance;
        public double GetWeight => _weight;
        public int GetID => _ID;
        public string GetDescription => _description;
        public int TransportID{get{return _transportID;} set{_transportID = value;}}

        public Order(int ID, string description, double weight, double distance)
        {
            _ID = ID;
            _description = description;
            _weight = weight;
            _distance = distance;
            _transportID = -1;
        }
    }