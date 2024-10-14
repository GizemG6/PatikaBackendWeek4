Book book1 = new Book(); // The 'new' keyword creates an instance of the Book class
book1.Title = "Adı Aylin";
book1.AuthorFirstName = "Ayşe";
book1.AuthorLastName = "Kulin";
book1.PageCount = 398;
book1.Publisher = "Remzi Kitabevi";
book1.DisplayBookInfo();

Book book2 = new Book("Adı Aylin", "Ayşe", "Kulin", 398, "Remzi Kitabevi"); // 'new' keyword creates a new instance, while constructor assigns initial values
book2.DisplayBookInfo();