namespace STUDY.OOP.LibraryManagement;

internal class Book
{
    string Name;
    string Location;

    internal Book()
    {
        Console.WriteLine($"Book name and location are unknown");
    }

    internal Book(string name)
    {
        Name = name;
        Console.WriteLine($"Book name = {name} and location is unknown");
    }

    internal Book(string name, string location)
    {
        Name = name;
        Location = location;

        Console.WriteLine($"Book name = {name} and location is {location}");
    }
}
