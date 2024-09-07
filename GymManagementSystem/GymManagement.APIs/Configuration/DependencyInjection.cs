using GymManagement.APIs.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

namespace GymManagement.APIs.Configuration
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddAPIsServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddJwtBearerToken(configuration)
                    .AddSwagger()
                    .AddCorsServices()
                    .AddLoginManager();

            return services;
        }

        private static IServiceCollection AddJwtBearerToken(this IServiceCollection services, IConfiguration configuration)
        {
            var jwtOptions = configuration.GetSection("JwtOptions").Get<JwtOptions>();

            services.Configure<JwtOptions>(configuration.GetSection("JwtOptions"));
            services.AddSingleton<JwtOptions>()
                    .AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                    .AddJwtBearer(options =>
                    {
                        options.SaveToken = true;
                        options.TokenValidationParameters = new TokenValidationParameters
                        {
                            ValidateLifetime = true,
                            ClockSkew = TimeSpan.Zero,
                            ValidateIssuer = true,
                            ValidIssuer = jwtOptions.Issuer,
                            ValidateAudience = true,
                            ValidAudience = jwtOptions.Audience,
                            ValidateIssuerSigningKey = true,
                            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SigningKey))
                        };
                    });

            return services;
        }

        private static IServiceCollection AddSwagger(this IServiceCollection services)
        {
            services.AddEndpointsApiExplorer()
                    .AddSwaggerGen(o =>
                    {
                        o.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme()
                        {
                            Name = "Authorization",
                            Type = SecuritySchemeType.ApiKey,
                            Scheme = "Bearer",
                            BearerFormat = "JWT",
                            In = ParameterLocation.Header,
                            Description = "Enter the jwt key"
                        });

                        o.AddSecurityRequirement(new OpenApiSecurityRequirement()
                        {
                            {
                                new OpenApiSecurityScheme()
                                {
                                    Reference = new OpenApiReference()
                                    {
                                        Type = ReferenceType.SecurityScheme,
                                        Id = "Bearer"
                                    },
                                    Name = "Bearer",
                                    In = ParameterLocation.Header
                                },
                                new List<string>()
                            }
                        });
                    });

            return services;
        }

        private static IServiceCollection AddLoginManager(this IServiceCollection services)
        {
            services.AddScoped<LoginManager>();

            return services;
        }

        private static IServiceCollection AddCorsServices(this IServiceCollection services)
        {
            services.AddCors(option => option.AddDefaultPolicy(policy => policy.AllowAnyHeader().AllowAnyMethod().AllowAnyOrigin()));

            return services;
        }
    }
}
