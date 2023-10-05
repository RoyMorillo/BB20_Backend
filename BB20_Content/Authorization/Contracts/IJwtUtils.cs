namespace BB20_Content.Authorization.Contracts;

public interface IJwtUtils
{
    public int ValidateJwtToken(string token);
}
