namespace STUDY.OOP.LibraryManagement;

internal class Book
{
    public int Id { get; set; } 
    public string Name { get; set; }
    public string Location { get; set; }
    public string Author { get; set; }
    public string Category { get; set; }
    public int Pages { get; set; }

    internal Book(int id, string name, string author, string category, string location, int pages)
    {
        Id = id;
        Name = name;  
        Author = author;
        Category = category;
        Location = location;
        Pages = pages;
    }
}
