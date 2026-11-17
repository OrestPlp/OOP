
namespace LAB_4;


class Program
{
   
    static void Main()
    {
        List<User> UserList = new List<User>();
        List<Book> BookList = new List<Book>();
        
        User user0 = new User(0, "Олег Л.");
        User user1 = new User(1, "Павло С.");
        User user2 = new User(2, "Світлана Ь.");
        User user3 = new User(3, "Орест Ф.");
        User user4 = new User(4, "Надіслав В.");
        User user5 = new User(5, "Марина Ж.");
        UserList.Add(user0);
        UserList.Add(user1);
        UserList.Add(user2);
        UserList.Add(user3);
        UserList.Add(user4);
        UserList.Add(user5);
       

        Book book0 = new Book(0,"Книга0","Автор4");
        Book book1 = new Book(1,"Об'єктно-орієнтоване програмування для початківців","Об'єкт Програменко");
        Book book2 = new Book(2,"Цікава книга","Професійний Письменник");
        Book book3 = new Book(3,"Samsung Galaxy A51:інструкція користувача","Самсунг Смартфоненко");
        Book book4 = new Book(4,"Кримінальний Кодекс України","Верховна Рада");
        Book book5 = new Book(5,"Біблія 3","Євген Шелест");
        BookList.Add(book0);
        BookList.Add(book1);
        BookList.Add(book2);
        BookList.Add(book3);
        BookList.Add(book4);
        BookList.Add(book5);


        Console.WriteLine("Бібліотека");    
        Library library = new Library();
        library.Run(UserList, BookList);

           
    }
}
