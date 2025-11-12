using Application.Constants;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace API.Extentions
{
    public static class ClaimsPrincipalExtensions
    {
        public static Guid GetUserId(this ClaimsPrincipal user)
        {
            var sid = user.FindFirst(JwtRegisteredClaimNames.Sid)?.Value;
            return Guid.TryParse(sid, out var id)
                ? id
                : throw new UnauthorizedAccessException(Message.UserMessage.MissingToken);
        }
    }
}
