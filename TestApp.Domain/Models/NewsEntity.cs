using System;

namespace TestApp.Domain.Models;

public class NewsEntity 
{
    public Guid Id { get; set; }
    public string Title { get; set; }
    public string Text { get; set; }
    public Guid AuthorId { get; set; }
    public AuthorEntity Author { get; set; }
}