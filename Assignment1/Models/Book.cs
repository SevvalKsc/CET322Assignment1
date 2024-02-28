namespace Assignment1.Models;

public class Book
{
    public string Name { get; set; }
    public string Author { get; set; }
    public int PageNum { get; set; }
    public DateTime DueDate { get; set; }
    public int DaysRemaining { get; set; }
    
}