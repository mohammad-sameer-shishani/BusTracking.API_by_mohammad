using System.Text;
using BusTracking.Core.Data;
using BusTracking.Core.ICommon;
using BusTracking.Core.IRepository;
using BusTracking.Core.IService;
using BusTracking.Infra.Common;
using BusTracking.Infra.Repository;
using BusTracking.Infra.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.IdentityModel.Tokens;

namespace BusTracking.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();
            builder.Services.AddScoped<IDbContext,DbContext>();
            builder.Services.AddScoped<IChildRepository,ChildRepository>();
            builder.Services.AddScoped<IChildService, ChildService>();
            builder.Services.AddScoped<ILoginRepository,LoginRepository>();
            builder.Services.AddScoped<ILoginService,LoginService>();
            builder.Services.AddScoped<IUserService, UserService>();
            builder.Services.AddScoped<IUserRepository, UserRepository>();
            builder.Services.AddScoped<ISearchChildrenRepository,SearchChildrenRepository>();
            builder.Services.AddScoped<ISearchChildrenService,SearchChildrenService>();
            builder.Services.AddScoped<IUpdateProfileRepository,UpdateProfileRepository>();
            builder.Services.AddScoped<IUpdateProfileService, UpdateProfileService>();
            builder.Services.AddScoped<IRoleRepository,RoleRepository>();


            builder.Services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            }).AddJwtBearer(x => x.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = false,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("This is our secret key of the bus tracking system This is our secret key of the bus tracking system"))
            });


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

            app.Run();
        }
    }
}
