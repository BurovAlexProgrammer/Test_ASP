// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Microsoft.EntityFrameworkCore;
// using TestApp.Domain.Contracts;
// using TestApp.Domain.Models;
// using TestApp.Domain.Repositories;
//
// namespace TestApp.DAL.Postgres.Repositories;
//
// public class AuthorRepository
// {
//     private PostgresDbContext _dbContext;
//
//     public AuthorRepository(PostgresDbContext dbContext)
//     {
//         _dbContext = dbContext;
//     }
//
//     public Task<AuthorEntity> GetById(Guid id)
//     {
//         return _dbContext.Authors.FirstOrDefaultAsync(x => x.Id == id);
//     }
//
//     public Task<IEnumerable<AuthorEntity>> Select()
//     {
//         throw new NotImplementedException();
//     }
//
//     public Task<bool> Create(IAuthorEntity newEntity)
//     {
//         throw new NotImplementedException();
//     }
//
//     public Task<bool> Delete(Guid id)
//     {
//         throw new NotImplementedException();
//     }
// }