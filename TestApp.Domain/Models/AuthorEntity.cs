using System;
using System.Collections.Generic;

namespace TestApp.Domain.Models;

public class AuthorEntity
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public List<NewsEntity> News {get; set;}
}