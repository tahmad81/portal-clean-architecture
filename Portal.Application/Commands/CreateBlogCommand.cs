using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Application.Commands
{
    public class CreateBlogCommand:IRequest<Guid>
    {
        public string Title { get; set; }= string.Empty;
        public string Content { get; set; }= string.Empty;

    }
}
