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
    public class GetBlogsHandler : IRequestHandler<GetBlogQuery, IEnumerable<Domain.Entities.Blog>>
    {
        private readonly IBlogRepository _blogRepository;
        public GetBlogsHandler(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public async Task<IEnumerable<Blog>> Handle(GetBlogQuery request, CancellationToken cancellationToken)
        {
            return await _blogRepository.GetAllAsync();
        }
    }
}
