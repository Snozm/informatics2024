using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        library.AddBook("House of Leaves");

        library.BorrowBook("Vladi", "House of Leaves");
        library.BorrowBook("Vladi", "The Great Gatsby");
        library.BorrowBook("Martin", "House of Leaves");
        library.ReturnBook("Vladi", "House of Leaves");
        library.BorrowBook("Martin", "House of Leaves");
    }
}
public class Library
{
    private Dictionary<string, string> books;
    private Dictionary<string, Dictionary<string, DateTime>> borrowers;

    public Library()
    {
        books = new Dictionary<string, string>();
        borrowers = new Dictionary<string, Dictionary<string, DateTime>>();
    }
    public void AddBook(string name)
    {
        if (books.ContainsKey(name))
        {
            books[name] = "avaliable";
            return;
        }
        books.Add(name, "avaliable");
    }
    public void BorrowBook(string borrower, string book)
    {
        if (!books.ContainsKey(book))
        {
            Console.WriteLine($"{book} isn't in stock.");
            return;
        }
        else if(books[book] != "avaliable"){
            Console.WriteLine($"{book} is already borrowed by {books[book]}");
            return;
        }
        books[book] = borrower;
        if (!borrowers.ContainsKey(borrower))
        {
            borrowers.Add(borrower, new Dictionary<string, DateTime>());
        }
        DateTime now = DateTime.Now;
        int monthDue = (now.Month + 2) % 12 + 1; //books due in 2 months, so check if month is valid and add 1 to return to 1-12 range
        borrowers[borrower].Add(book, new DateTime(now.Year, monthDue, 1));
        Console.WriteLine($"{book} borrowed by {borrower}.");
        return;
    }
    public void ReturnBook(string borrower, string book)
    {
        if (!books.ContainsKey(book))
        {
            Console.WriteLine($"{book} isn't in stock.");
            return;
        }
        else if (books[book] != borrower)
        {
            Console.WriteLine($"{book} is not owned by {borrower}");
            return;
        }
        books[book] = "avaliable";
        borrowers[borrower].Remove(book);
        Console.WriteLine($"{book} returned by {borrower}.");
        return;
    }
}