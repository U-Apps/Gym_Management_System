using GymManagement.BusinessCore.Configuration;
using GymManagement.BusinessCore.Models;
using GymManagement.DataAccess.Data;
using GymManagement.DataAccess.Repositories.Base;
using GymManagement.DataAccess.Repositories;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using GymManagement.BusinessCore.AutoMapper;
using GymManagement.BusinessCore.Services;
using GymManagement.APIs.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using GymManagement.BusinessCore.helper;
using JwtOptions = GymManagement.BusinessCore.helper.JwtOptions;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddControllers();

var Constr = builder.Configuration.GetSection("Constr").Value;
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(Constr,
b => b.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)));




// register Identity
builder.Services.AddIdentity<AppUser, IdentityRole>(options =>
{
    options.Password.RequireDigit = true;
    options.Password.RequireLowercase = false;
    options.Password.RequireUppercase = false;
    options.Password.RequireNonAlphanumeric = false;
    options.Password.RequiredUniqueChars = 0;
    options.Password.RequiredLength = 5;
})
    .AddEntityFrameworkStores<AppDbContext>()
    .AddDefaultTokenProviders();


// register objects
builder.Services.AddTransient<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddAutoMapper(typeof(MapperProfile).Assembly);




var jwtOptions = builder.Configuration.GetSection("JwtOptions").Get<JwtOptions>();
builder.Services.AddSingleton(jwtOptions);

// register authentication
builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
    .AddJwtBearer(JwtBearerDefaults.AuthenticationScheme, options =>
    {
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = jwtOptions.Issure,
            ValidateAudience = true,
            ValidAudience = jwtOptions.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SigningKey)),
            ClockSkew = TimeSpan.Zero
        };
    });


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
