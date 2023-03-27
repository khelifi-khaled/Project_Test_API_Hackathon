
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: "test",
                      policy =>
                      {
                          policy.AllowAnyOrigin();
                      });
});

// Add services to the container.

builder.Services.AddControllers();

IConfiguration config = builder.Configuration;

builder.Services.AddHttpClient("Default", (client) =>
{
    //client.DefaultRequestHeaders.Add("Authorization", "6802e6ab7e744944b198bbc2c8f20215");
    client.BaseAddress = new Uri(config[key: "ApiUri"]);
});





// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

//Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAuthorization();

app.MapControllers();

app.Run();
