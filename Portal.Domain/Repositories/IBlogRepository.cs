
using Portal.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Domain.Interfaces.Repositories
{
    public interface IBlogRepository
    {
        Task AddAsync(Blog blog);
        Task<IEnumerable<Blog>> GetAllAsync();
    }
}
