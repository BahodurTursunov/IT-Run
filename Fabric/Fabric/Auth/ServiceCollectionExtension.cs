using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

namespace Fabric.Auth
{
    public static class ServiceCollectionExtensions
    {
        private static void AddMyAuth(this IServiceCollection service)
        {
            service.AddAuthorization(options =>
            {
                options.AddPolicy("AdminOnly", policy =>
                {
                    policy.RequireRole("admin");
                    policy.RequireRole("editor");
                });
                options.AddPolicy("UserOnly", policy => policy.RequireRole("User"));
            });

            service.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true, // указывает, будет ли валидироваться издатель при валидации токена
                        ValidIssuer = AuthOptions.Issuer, // строка, представляющая издателя
                        ValidateAudience = true, // будет ли валидироваться потребитель токена
                        ValidAudience = AuthOptions.Audience, // утановка потребителя токена
                        ValidateLifetime = true, // будет ли валидироваться время существования токена
                        ValidateIssuerSigningKey = true, // валидация ключа безопасности
                        IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey() // установка ключа безопасности
                    };
                });
        }
    }
}
