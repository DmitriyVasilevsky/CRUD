using BussinessLogic;
using DataAccess;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDataAccess();
builder.Services.AddBusinessLogic();
builder.Services.AddControllers();
builder.Services.AddSwaggerGen();
var app = builder.Build();//fghjkl

app.MapControllers();
app.UseSwagger();
app.UseSwaggerUI();
app.Run();
//commit//
//new commit//
//exstensions методы//
//женерик методы
// .гитигнор для проекта