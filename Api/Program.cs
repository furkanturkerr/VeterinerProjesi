using System.Reflection;
using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccessLayer.Abstract;
using DataAccessLayer.Concrate;
using DataAccessLayer.EntityFramework;
using DataAccessLayer.UnitOfWork;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<VetContext>();
builder.Services.AddAutoMapper(Assembly.GetExecutingAssembly());

builder.Services.AddScoped<IUowDal, UowDal>();
builder.Services.AddScoped<IAnimalService, AnimalManager>();
builder.Services.AddScoped<IAnimalDal, EfAnimalDal>();
builder.Services.AddScoped<IAppointmentDal, EfAppointmentDal>();
builder.Services.AddScoped<IAppointmentService, AppointmentManager>();
builder.Services.AddScoped<ITreatmentService, TreatmentManager>();
builder.Services.AddScoped<ITreatmentDal, EfTreatmentDal>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// API Controller Mapping
app.MapControllers();

app.Run();