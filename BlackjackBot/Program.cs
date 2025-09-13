
using BlackjackBot.Data;
using Microsoft.EntityFrameworkCore;
using Telegram.Bot;

namespace BlackjackBot
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            DotNetEnv.Env.Load();

            var builder = WebApplication.CreateBuilder(args);

            var connectionString = builder.Configuration.GetConnectionString("Default");

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<ApplicationContext>
                (options => 
                {
                    options.UseNpgsql(connectionString);
                });

            builder.Services.AddSingleton<ITelegramBotClient>(sp =>
            {
                var config = sp.GetRequiredService<IConfiguration>();
                var token = config["BOT:TOKEN"];

                return new TelegramBotClient(token);
            });

            builder.WebHost.UseUrls("http://0.0.0.0:80");


            var app = builder.Build();

            await using (var scope = app.Services.CreateAsyncScope())
            {
                var db = scope.ServiceProvider.GetRequiredService<ApplicationContext>();
                await db.Database.MigrateAsync();
            }

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            //app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();

            app.Run();
        }
    }
}
