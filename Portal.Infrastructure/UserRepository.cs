using Microsoft.EntityFrameworkCore;
using Portal.Domain.Entities;
using Portal.Domain.Interfaces.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Infrastructure
{
    
    public class UserRepository : IUserRepository
    {
        private readonly AppDBContext _dbContext;   
        public UserRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public Task<User?> GetByEmailAsync(string email)
        {
            return _dbContext.Users.FirstOrDefaultAsync(u => u.Email == email);
        }
    }
}
