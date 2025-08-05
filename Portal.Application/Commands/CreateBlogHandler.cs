
using Portal.Domain.Entities;
using Portal.Domain.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Portal.Domain.Interfaces.Repositories;

namespace Portal.Application.Commands
{
    public class CreateBlogHandler : IRequestHandler<CreateBlogCommand, Guid>
    {
        private readonly IBlogRepository _repo;

        public CreateBlogHandler(IBlogRepository repo)
        {
            _repo = repo;
        }
        public async Task<Guid> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {
            var blog = new Blog
            {
                Id = Guid.NewGuid(),
                Title = request.Title,
                Content = request.Content,
                CreatedAt = DateTime.UtcNow
            };

            await _repo.AddAsync(blog);
            return blog.Id;
        }
    }
}
