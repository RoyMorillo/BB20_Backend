namespace BB20_ContentAudios.Authorization.Contracts;

public interface IJwtUtils
{
    public int ValidateJwtToken(string token);
}
