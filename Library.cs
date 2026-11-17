namespace LAB_4;

class Library
{
    public void Run(List<User> userList, List<Book> bookList)
    {
       while(true)
        {
            Console.WriteLine("------[Меню]------------------------");
            Console.WriteLine("""
            [1] - Орендувати книгу
            [2] - Повернути книгу
            [3] - Переглянути інформацію про всі книги
            [4] - Переглянути інформацію про всіх користувачів
            [5] - Доступні книги
            [6] - Орендовані книги
            [7] - Вихід
            """);
            Console.WriteLine("--Оберіть дію:--");
            string input = Console.ReadLine();
            
            switch(input)
            {
                case "1": RentBook(userList, bookList); break;
                case "2": ReturnBook(userList, bookList); break;
                case "3": ShowBookInfo(bookList); break;
                case "4": ShowUserInfo(userList); break;
                case "5": ShowAvailable(bookList); break;
                case "6": ShowRented(bookList); break;  
                case "7": return;   
                default: Console.WriteLine("Некоректне введення!"); break;         
                
            }   
        }   
    }

    public void ShowUserInfo(List<User> Users)
    {
        Console.WriteLine("------[Інформаіця про усіх користувачів]------------------------");
        foreach(User user in Users)
        {
            Console.WriteLine($"""
            +--------------------
            |Користувач {user.getID}:
            +--------------------
            Ім'я: {user.getUserName}
            Орендовані книжки:
            """);
            
            if(user.userRentedBooks.Count() != 0)
                {
                foreach(Book book in user.userRentedBooks)
                {
                    Console.WriteLine($"""
                        - {book.getTitle}, {book.getAuthor}
                    """);
                }
                }
            else Console.WriteLine("Відсутні");
            Console.WriteLine("""

            """);
        }
    }


    public void ShowBookInfo(List<Book> Books)
    {
        Console.WriteLine("------[Інформаіця про усі книжки]------------------------");
        foreach(Book book in Books)
        {
            string available;
            if(book.available == true) available = "Вільна";
            else available = "Орендована";
            Console.WriteLine($"""
            +--------------------
            |{book.getTitle}:
            +--------------------
            Автор: {book.getAuthor}
            Статус: {available}


            """);
        }
    }

    public void ShowRented(List<Book> Books)
    {
        Console.WriteLine("------[Орендовані книжки]------------------------");
        int available_count = 0;
        foreach(Book book in Books)
        {
            if(book.available == false) 
            {
                Console.WriteLine("- " + book.getTitle);
                available_count += 1;
            }
        }
        if(available_count == Books.Count) Console.WriteLine("Усі книжки вільні");
    }

    public void ShowAvailable(List<Book> Books)
    {
        Console.WriteLine("------[Доступні книжки]------------------------");
        int available_count = 0;
        foreach(Book book in Books)
        {
            if(book.available == true) Console.WriteLine("- " + book.getTitle);
            available_count += 1;
        }
        if(available_count == 0) Console.WriteLine("Усі книжки орендовані");
    }

    public User CheckUser(List<User> userList)
    {
        string name;
        while(true)
        {
            Console.WriteLine("Введіть ім'я користувача:");
            name = Console.ReadLine();
            foreach(User user in userList)
            {
                if(user.getUserName == name) return user;  
            }
            Console.WriteLine("Користувача з таким іменем не існує."); 

        }
        
    }

    public Book CheckBook(List<Book> bookList)
    {
        string title;
        while(true)
        {
            Console.WriteLine("Введіть назву книжки:");
            title = Console.ReadLine();
            foreach(Book book in bookList)
            {
                if(book.getTitle == title) return book;
            }
            Console.WriteLine("Книжки з такою назвою не існує.");
        }
        
    }
    
    public void RentBook(List<User> userList, List<Book> bookList)
    {
        Console.WriteLine("------[Оренда книжок]------------------------");
        User user = CheckUser(userList);
        Book book = CheckBook(bookList);
        if(book.available == true)
        {
            book.available = false;
            user.userRentedBooks.Add(book);
            Console.WriteLine($"Книга '{book.getTitle}' успішно орендована користувачу {user.getUserName}");
        }
        else if(user.userRentedBooks.Contains(book) == true)
        {
            Console.WriteLine($"Книга '{book.getTitle}' вже була орендована користувачем {user.getUserName}");
        }
        else
        {
           Console.WriteLine($"Книга '{book.getTitle}' наразі орендована іншим користувачем"); 
        }
    }

    public void ReturnBook(List<User> userList, List<Book> bookList)
    {
        Console.WriteLine("------[Повернення книжок]------------------------");
        User user = CheckUser(userList);
        Book book = CheckBook(bookList);
        
        if(user.userRentedBooks.Contains(book) == true)
        {
            book.available = true;
            user.userRentedBooks.Remove(book);
            Console.WriteLine($"Книга '{book.getTitle}' повернена до бібліотеки");
        }
        else
        {
           Console.WriteLine($"Книга '{book.getTitle}' не орендована користувачем {user.getUserName}"); 
        }
    }
}