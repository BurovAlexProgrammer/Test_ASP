using System;
using System.Collections.Generic;

namespace TestApp.Core.Postgres.Models
{
    public class AuthorEntity
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public List<NewsEntity> News {get; set;}
    }
}