using Rockseatauction.API.Entitys;
using Rockseatauction.API.Repositories;

namespace Rockseatauction.API.Services;

public class LoggedUser
{
    private readonly IHttpContextAccessor _HttpContextAccessor;
    public LoggedUser(IHttpContextAccessor httpContext)
    {
        _HttpContextAccessor = httpContext;
    }
    public User User()
    {
        var repository = new RocketSeatAuctionDBContext();

        var token = TokenOnRequest();
        var email = FromBase64String(token);

        return repository.Users.First(user => user.Email.Equals(email));
    }

    private string TokenOnRequest()
    {
        var authentication = _HttpContextAccessor.HttpContext!.Request.Headers.Authorization.ToString();

        return authentication["Bearer ".Length..];
    }

    private string FromBase64String(string base64)
    {
        var data = Convert.FromBase64String(base64);

        return System.Text.Encoding.UTF8.GetString(data);
    }
}
