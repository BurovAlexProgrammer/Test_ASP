namespace TestApp.DAL.Postgres.Repositories;

public class Repository
{
    //https://www.thereformedprogrammer.net/is-the-repository-pattern-useful-with-entity-framework-core/
    
    //The repository pattern isn’t useful with EF Core.
    //EF Core already implements a repository pattern, so layering another Rep/UoW pattern on top of EF Core isn’t helpful.
    
    //Я буду реализовывать репозитории для переезда текущего проекта с Firebase на Postrges
    //Предполагаю что настройка EntityFramework для столь различных структур ДБ будет сложнее,
    //чем реализация легаси запросов к Firebase, запись данных в Postgres и дальнейший переход на EntityFramework   
}