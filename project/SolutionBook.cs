using System;

public class Program{

    public static void Main(){
        Check();
    }

    public class Book
    {
        private string title;

        public string Title
        {
            get => title;
            set => title = value;
        }

        public Book()
        {
            title = "none";
        }
    }

    public static void Check(){
        var book = new Book();
        book.Title = "Hogwarts..";
        Console.WriteLine(book.Title);
    }
}