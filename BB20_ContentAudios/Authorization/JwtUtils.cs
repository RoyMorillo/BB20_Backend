using BB20_ContentAudios.Authorization.Contracts;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace BB20_ContentAudios.Authorization;

public class JwtUtils : IJwtUtils
{
    public int ValidateJwtToken(string token)
    {
        if (token == null)
            return 0;

        var tokenHandler = new JwtSecurityTokenHandler();

        var dir = Directory.GetCurrentDirectory();

        var builder = new ConfigurationBuilder()
        .SetBasePath(Directory.GetCurrentDirectory())
        .AddJsonFile("appsettings.json");

        IConfiguration _configuration = builder.Build();

        var secret = _configuration.GetValue<string>("Secret");

        var key = Encoding.ASCII.GetBytes(secret);
        try
        {
            tokenHandler.ValidateToken(token, new TokenValidationParameters
            {
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(key),
                ValidateIssuer = false,
                ValidateAudience = false,
                ClockSkew = TimeSpan.Zero
            }, out SecurityToken validatedToken);

            var jwtToken = (JwtSecurityToken)validatedToken;
            var accountId = int.Parse(jwtToken.Claims.First(x => x.Type == "id").Value.ToString());

            return accountId;
        }
        catch
        {
            return 0;
        }
    }
}
