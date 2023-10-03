using Application.Contracts.Persistence;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class UserRepository : BaseRepository<User>, IUserRepository
    {

        public UserRepository(ApplicationDbContext _dbContext) : base(_dbContext)
        {
        }

        public async Task<User?> GetByUserNameAsync(string userName)
        {
            User? entity = await _dbContext.Users!.Where(u => u.UserName == userName).FirstOrDefaultAsync();
            return entity;
        }
    }
}
