namespace BB20_Categories.Authorization.Contracts;

public interface IJwtUtils
{
    public int ValidateJwtToken(string token);
}
