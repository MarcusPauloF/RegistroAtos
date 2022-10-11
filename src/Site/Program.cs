using MediatR;
using Microsoft.EntityFrameworkCore;
using RegistroAtos.Domain.Repositorio;
using RegistroAtos.Infra.DataBase;
using RegistroAtos.Infra.Repositorio;
using RegistroDeAtos.Core.Mediator;
using RegistroDeAtos.Services.CasamentoService.Commands.Input;
using RegistroDeAtos.Services.CasamentoService.Event;
using RegistroDeAtos.Services.CasamentoService.Query;
using RegistroDeAtos.Services.NascimentoService.Commands.Event;
using RegistroDeAtos.Services.NascimentoService.Commands.Input;
using RegistroDeAtos.Services.NascimentoService.Query;
using RegistroDeAtos.Services.ObitoService.Commands.Input;
using RegistroDeAtos.Services.ObitoService.Event;
using RegistroDeAtos.Services.ObitoService.Query;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddMediatR(typeof(Program));
builder.Services.AddScoped<IMediatorHandler, MediatorHandler>();
builder.Services.AddScoped<IRequestHandler<CasamentoCommand, bool>, CadastrarCasamentoHandler>();

builder.Services.AddScoped<ICasamentoRepository, CasamentoRepository>();
builder.Services.AddScoped<IRequestHandler<NascimentoCommand, bool>, CadastrarNascimentoHandler>();
builder.Services.AddScoped<INascimentoRepository, NascimentoRepository>();
builder.Services.AddScoped<IConsultarCasamentoQuery, ConsultarCasamentoQuery>();
builder.Services.AddScoped<IConsultarNascimentoQuery, ConsultarNascimentoQuery>();
builder.Services.AddScoped<IConsultarObitoQuery, ConsultarObitoQuery>();
builder.Services.AddScoped<IObitoRepository, ObitoRepository>();
builder.Services.AddScoped<IRequestHandler<ObitoCommand, bool>, CadastrarObitoHandler>();

builder.Services.AddEntityFrameworkNpgsql()
             .AddDbContext<Context>(options => options.UseNpgsql(builder.Configuration.GetConnectionString("RegistroDeAto")));
AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);

//AddEntityFrameworkNpgsql().AddDbContext<Context>(op => op.UseNpgsql(builder.Configuration.GetConnectionString("RegistroDeAto"))
//    .EnableSensitiveDataLogging()
//    .EnableDetailedErrors());


var app = builder.Build();



// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
