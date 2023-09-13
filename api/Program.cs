using vue_cat_browser_api.Models;
using vue_cat_browser_api.Services;

var builder = WebApplication.CreateBuilder(args);
var myAllowSpecificOrigins = "_myAllowSpecificOrigins";


// Add services to the container.
builder.Services.Configure<CatsDatabaseSettings>(builder.Configuration.GetSection("CatsDatabase"));
builder.Services.AddSingleton<CatsService>();
builder.Services.AddControllers();
builder.Services.AddHostedService<DbInitializerHostedService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
  options.AddPolicy(name: myAllowSpecificOrigins,
                    policy =>
                    {
                      policy.WithOrigins("http://127.0.0.1:5173",
                      "https://127.0.0.1:5173",
                      "http://catbrowser.netlify.app",
                      "https://catbrowser.netlify.app").WithMethods("GET", "POST", "PUT", "DELETE").AllowAnyHeader();
                    });
});

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

app.UseCors(myAllowSpecificOrigins);

app.Run();
