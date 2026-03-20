using BussinessLogic;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDataAccess();
builder.Services.AddBusinessLogic();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var apps = builder.Build();//fghjkl

apps.MapControllers();
apps.UseSwagger();
apps.UseSwaggerUI();
apps.Run();
//commit//
//new commit//
//exstensions методы//
//женерик методы

// .гитигнор для проекта
