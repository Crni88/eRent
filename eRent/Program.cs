using eRent;
using eRent.Filters;
using eRent.Services.DataDB;
using eRent.Services.Korisnici;
using eRent.Services.KorisnikTagovi;
using eRent.Services.Nekretnina;
using eRent.Services.NekretninaKorisnik;
using eRent.Services.NekretninaTagovi;
using eRent.Services.Payment;
using eRent.Services.Posjeta;
using eRent.Services.Rejting;
using eRent.Services.Rezervacija;
using eRent.Services.Tags;
using eRent.Services.Task;
using eRent.Services.Ugovor;
using eRent.Services.Uloge;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers(x => x.Filters.Add<ErrorFilter>());
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen(c =>
        {
            c.AddSecurityDefinition("BasicAuthentication", new Microsoft.OpenApi.Models.OpenApiSecurityScheme
            {
                Type = Microsoft.OpenApi.Models.SecuritySchemeType.Http,
                Scheme = "basic"
            });

            c.AddSecurityRequirement(new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference { Type = ReferenceType.SecurityScheme, Id = "BasicAuthentication" }
            },
            new string[]{}
        }
    });
        });

        builder.Services.AddTransient<IUlogeService, UlogeService>();
        builder.Services.AddTransient<IKorisniciService, KorisniciService>();
        builder.Services.AddTransient<INekretnineService, NekretnineService>();
        builder.Services.AddTransient<ITagsService, TagsService>();
        builder.Services.AddTransient<INekretninaKorisnikService, NekretninaKorisnikService>();
        builder.Services.AddTransient<IRezervacijaService, RezervacijaService>();
        builder.Services.AddTransient<INekretninaTagovi, NekretninaTagoviService>();
        builder.Services.AddTransient<IPosjetaService, PosjetaService>();
        builder.Services.AddTransient<IRejtingService, RejtingService>();
        builder.Services.AddTransient<IPaymentRequestService, PaymentRequestService>();
        builder.Services.AddTransient<IUgovorService, UgovorService>();
        builder.Services.AddTransient<IKorisnikTagoviService, KorisnikTagoviService>();
        builder.Services.AddTransient<ITaskService, TaskService>();
        builder.Services.AddAutoMapper(typeof(IKorisniciService));

        builder.Services.AddAuthentication("BasicAuthentication")
            .AddScheme<AuthenticationSchemeOptions, BasicAuthHandler>("BasicAuthentication", null);


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

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllers();

        using (var scope = app.Services.CreateScope())
{
    var dataContext = scope.ServiceProvider.GetRequiredService<ERentContext>();
    dataContext.Database.Migrate();
}
        app.Run();
    }
}