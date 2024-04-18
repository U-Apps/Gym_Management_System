using AutoMapper;
using Jym_Management_APIs.Authentication;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services;
using Jym_Management_BussinessLayer.Services.Base;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
var jwtOptions = builder.Configuration.GetSection("JwtOptions").Get<JwtOptions>();

// Read appsettings.json
//var configuration = new ConfigurationBuilder()
//    .SetBasePath(Directory.GetCurrentDirectory())
//    .AddJsonFile("appsettings.json")
//    .Build();
builder.Services.Configure<JwtOptions>(builder.Configuration.GetSection("JwtOptions"));
builder.Services.AddSingleton<JwtOptions>();
builder.Services.AddScoped<AuthenticationService>();
builder.Services.AddScoped<User>();
builder.Services.AddScoped<UserService>();
builder.Services.AddScoped<LoginManager>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.SaveToken = true;
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidIssuer = jwtOptions.Issuer,
            ValidateAudience = true,
            ValidAudience = jwtOptions.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtOptions.SigningKey))
        };
    }
    );

builder.Services.AddScoped<IBaseServices<Employee>,EmployeeService>();
builder.Services.AddScoped<IBaseServices<Person>, PersonService>();
builder.Services.AddScoped<IBaseServices<Member>, MemberService>();
//builder.Services.AddScoped<IBaseServices<User>, UserService>();
//builder.Services.AddScoped<IBaseServices<Permssion>, PermssionService>();
builder.Services.AddScoped<RoleService>();
builder.Services.AddScoped<IBaseServices<Job>, JobService>();
builder.Services.AddScoped<IBaseServices<JobHistory>, JobHistoryService>();
builder.Services.AddScoped<IBaseServices<Period>, PeriodService>();
builder.Services.AddScoped<IBaseServices<SubscriptionPeriod>, SubscriptionPeriodServices>();
builder.Services.AddScoped<IBaseServices<SubscriptionPayment>, SubscriptionPaymentServices>();
builder.Services.AddScoped<IBaseServices<Subscription>, SubscriptionServices>();
builder.Services.AddScoped<IBaseServices<ExerciseType>, ExerciseTypeService>();
builder.Services.AddScoped<IBaseServices<PayrollPayment>, PayrollPaymentService>();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
