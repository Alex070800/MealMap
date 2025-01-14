using MealMap.Service;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<MealTypeService>();
builder.Services.AddSingleton<UnitService>();
builder.Services.AddSingleton<ProductService>();
builder.Services.AddSingleton<FamilyService>();
builder.Services.AddSingleton<RecipeService>();
builder.Services.AddSingleton<DayService>();
builder.Services.AddSingleton<UserService>();

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
