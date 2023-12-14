using Domain.Entities.MockEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class MockSessionRepository : BaseRepository<MockSession>
    {
        public MockSessionRepository(ApplicationDbContext _dbContext) : base(_dbContext)
        {
            
        }
    }
}
