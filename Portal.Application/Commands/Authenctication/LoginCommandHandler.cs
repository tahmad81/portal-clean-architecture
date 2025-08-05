using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.Identity.Client;
using Portal.Application.Commands.Authenctication;
using Portal.Application.Common.Interfaces;
using Portal.Domain.Entities;
using Portal.Domain.Interfaces.Repositories;

public class LoginCommandHandler : IRequestHandler<LoginCommand, Portal.Application.Commands.Authenctication.AuthenticationResult>
{
    private readonly IUserRepository _userRepository;
    private readonly IJwtTokenGenerator _jwtTokenGenerator;
    private readonly IPasswordHasher<User> _passwordHasher;

    public LoginCommandHandler(
        IUserRepository userRepository,
        IJwtTokenGenerator jwtTokenGenerator,
        IPasswordHasher<User> passwordHasher)
    {
        _userRepository = userRepository;
        _jwtTokenGenerator = jwtTokenGenerator;
        _passwordHasher = passwordHasher;
    }

    public async Task<Portal.Application.Commands.Authenctication.AuthenticationResult> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await _userRepository.GetByEmailAsync(request.Email);
        if (user == null)
            throw new Exception("Invalid email or password");
        var passwordCheck = _passwordHasher.VerifyHashedPassword(user, user.PasswordHash, request.Password);
        if (passwordCheck == PasswordVerificationResult.Failed)
            throw new Exception("Invalid email or password");
        var token = _jwtTokenGenerator.GenerateToken(user);
        return new Portal.Application.Commands.Authenctication.AuthenticationResult
        {
            UserId = user.Id,
            Email = user.Email,
            Token = token
        };

    }
}
