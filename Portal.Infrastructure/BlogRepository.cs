using Portal.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portal.Domain.Interfaces.Repositories;

namespace Portal.Infrastructure
{
    public class BlogRepository : IBlogRepository
    {
        private readonly AppDBContext _context;
        public BlogRepository(AppDBContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
             }
        public async Task AddAsync(Blog blog)
        {
           _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Blog>> GetAllAsync()
        {
           return  await _context.Blogs.ToListAsync();
        }
    }
}
