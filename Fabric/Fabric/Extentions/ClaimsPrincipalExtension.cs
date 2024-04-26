using System.Security.Claims;

namespace Fabric.Extentions
{
    public static class ClaimsPrincipalExtension
    {
        public static Guid GetCurrectUserId(this ClaimsPrincipal principal)
        {
            var role = principal?.Claims.FirstOrDefault(c => c.Type == "Id")?.Value;
            if (Guid.TryParse(role, out Guid userId))
                return userId;

            return Guid.Empty;
        }
    }
}

