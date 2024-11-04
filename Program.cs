using LibrarySystem;

internal class Program
{
    private static void Main(string[] args)
    {
        Book book1 = new Book("Invitatie la vals", "Mihail Drumes");

        Book book2 = new Book("Looking for Alaska", "John Green", 297 );

        book1.CheckOut();

        book2.ReturnBook();

        Console.WriteLine(book1.ToString());
Console.WriteLine(book2.ToString());
    }
}