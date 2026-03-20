using BussinessLogic;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDataAccess();
builder.Services.AddBusinessLogic();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var webApplication = builder.Build();

webApplication.MapControllers();
webApplication.UseSwagger();
webApplication.UseSwaggerUI();
webApplication.Run();
//commit//
//new commit//
//exstensions методы//
//женерик методы

// .гитигнор для проекта
