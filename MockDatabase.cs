namespace STUDY.OOP.LibraryManagement;

internal static class MockDatabase
{
    internal static List<Book> Books = new()
     {
        new Book(1, "The Great Gatsby", "F. Scott Fitzgerald", "Fiction", "A1", 218),
        new Book(2, "To Kill a Mockingbird", "Harper Lee", "Fiction", "A2", 324),
        new Book(3, "1984", "George Orwell", "Dystopian", "A3", 328),
        new Book(4, "Pride and Prejudice", "Jane Austen", "Romance", "A4", 279),
        new Book(5, "The Catcher in the Rye", "J.D. Salinger", "Fiction", "A5", 214)
    };
}
