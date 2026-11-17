namespace LAB_4;

class Book
{
    private int _ID;
    private string _title;
    private string _author;
    private bool _available;


    
    public int ID {get {return _ID;}}
    public string getTitle {get {return _title;}}
    public string getAuthor {get {return _author;}}
    public bool available {get {return _available;} set {_available = value;}}
  

    public Book
    (
        int id, 
        string title,
        string author
    )

    {
        _ID = id;
        _title = title;
        _author = author;
        _available = true;
    }

    public void ChangeRenter(int ID, User renter)
    {
        _available = false;
    }

}