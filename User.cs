namespace LAB_4;

class User
{
    private int _ID;
    private string _name;
    private List<Book> _rentedBooks;

    public int getID => _ID;
    public string getUserName => _name;
    public List<Book> userRentedBooks => _rentedBooks;


    public string name => _name;
    
    
    public User(int id, string name)
    {
        _ID = id;
        _name = name;
        _rentedBooks = new List<Book>();
        _rentedBooks.Clear();
        
    }

    


}
