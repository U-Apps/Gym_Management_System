using GymManagement.APIs.Configuration;
using GymManagement.BusinessCore.Configuration;
using GymManagement.DataAccess.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Configure services
builder.Services.AddControllers();

builder.Services.AddAPIsServices(builder.Configuration)
                .AddBusinessCore()
                .AddDataAccess();


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
