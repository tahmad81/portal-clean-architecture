using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Application.Commands
{
    public class GetBlogQuery:IRequest<IEnumerable<Domain.Entities.Blog>>   
    {
    }
}
