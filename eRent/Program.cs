using eRent.Services.DataDB;
using eRent.Services.Korisnici;
using eRent.Services.Lokacija;
using eRent.Services.Nekretnina;
using eRent.Services.Tags;
using eRent.Services.Uloge;
using Microsoft.EntityFrameworkCore;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddTransient<IUlogeService, UlogeService>();
        builder.Services.AddTransient<IKorisniciService, KorisniciService>();
        builder.Services.AddTransient<ILokacijaService, LokacijaService>();
        builder.Services.AddTransient<INekretnineService, NekretnineService>();
        builder.Services.AddTransient<ITagsService, TagsService>();

        builder.Services.AddAutoMapper(typeof(IKorisniciService));


        builder.Services.AddDbContext<ERentContext>(options =>
        options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

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
    }
}