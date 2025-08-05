using Portal.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BlogAPI
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthController : ControllerBase
    {
        private readonly IMediator _mediator;
        public AuthController(IMediator mediator)
        {
            _mediator = mediator ?? throw new ArgumentNullException(nameof(mediator));
        }
       
    }
   
}
