using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Assignment1.Controllers;

public class BookController : Controller
{
    public IActionResult ShowBook(string name, string author, int pagenum, DateTime duedate)
    {
        Book book = new Book();
        int remainingNum = CalculateDaysRemaining(book.DueDate);

        book.Name = name;
        book.Author = author;
        book.PageNum = pagenum;
        book.DueDate = duedate;
        book.DaysRemaining = remainingNum;
        
        return View(book);
    }
    
    private int CalculateDaysRemaining(DateTime dueDate)
    {
        TimeSpan remainingTime = dueDate - DateTime.Now;
        return (int)remainingTime.TotalDays;
    }
}