using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Fabric.Auth
{
    public class AuthOptions
    {
        public const string Issuer = "FabricServer";
        public const string Audience = "MyAuthClient";
        const string Key = "3EC1EE51-1100-4347-BF22-EEB6CB8B0695";  
        public const int Lifetime = 30; 
        public static SymmetricSecurityKey GetSymmetricSecurityKey() =>
            new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Key));
    }
}
