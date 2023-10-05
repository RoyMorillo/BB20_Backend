using BB20_Content.SecurityModels;
using BB20_Content.SecurityModels.Enum;
using BB20_Content.SecurityRepository.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace BB20_Content.Authorization;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Method)]
public class AuthorizeAttribute : Attribute, IAuthorizationFilter
{
    private readonly IList<Role> _roles;

    public AuthorizeAttribute(params Role[] roles)
    {
        _roles = roles ?? new Role[] { };
    }

    public void OnAuthorization(AuthorizationFilterContext context)
    {
        var allowAnonymous = context.ActionDescriptor.EndpointMetadata.OfType<AllowAnonymousAttribute>().Any();
        if (allowAnonymous)
            return;

        string accessToken = context.HttpContext.Request.Headers["Authorization"];
        var infoTokenReturned = accessToken.Split(" ");

        JwtUtils jwtUtils = new JwtUtils();
        int accountId = jwtUtils.ValidateJwtToken(infoTokenReturned[1].Trim());
        BB20_SecurityGateWayContext securityContext = new BB20_SecurityGateWayContext();
        AccountService accountService = new AccountService(securityContext);
        var account = accountService.GetById(accountId);

        if (account == null || (_roles.Any() && !_roles.Contains((Role)account.Role)))
        {
            context.Result = new JsonResult(new { message = "Sin autorización" }) { StatusCode = StatusCodes.Status401Unauthorized };
        }
    }
}