using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Portal.Application.Commands.Authenctication
{
    public class AuthenticationResult
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Token { get; set; }
    }
}
