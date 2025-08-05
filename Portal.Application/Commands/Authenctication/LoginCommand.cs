using MediatR;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Application.Commands.Authenctication
{
    public record LoginCommand(string Email, string Password) : IRequest<AuthenticationResult>;

}
