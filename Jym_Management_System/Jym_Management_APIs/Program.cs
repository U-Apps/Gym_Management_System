using AutoMapper;
using Jym_Management_BussinessLayer.Modules;
using Jym_Management_BussinessLayer.Services;
using Jym_Management_BussinessLayer.Services.Base;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IBaseServices<Employee>,EmployeeService>();
builder.Services.AddScoped<IBaseServices<Person>, PersonService>();
builder.Services.AddScoped<IBaseServices<Member>, MemberService>();
builder.Services.AddScoped<IBaseServices<User>, UserServices>();
builder.Services.AddScoped<IBaseServices<Permssion>, PermssionService>();
builder.Services.AddScoped<IBaseServices<Role>, RoleService>();
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

app.UseAuthorization();

app.MapControllers();

app.Run();
