using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;
using Shared.Extensions.Consul;
using UserManagement.Config;

namespace TamagotchiUserAPI
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        public ConfigurationSetting _configurationSetting { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddSingleton<IMongoClient, MongoClient>(s =>
            {
                var uri = s.GetRequiredService<IConfiguration>()["MongoUri"];
                return new MongoClient(uri);
            });

            services.AddSingleton<IActiveMqLog, ActiveMQLog>(s =>
            {
                var uri =      s.GetRequiredService<IConfiguration>()["MQUri"];
                var username = s.GetRequiredService<IConfiguration>()["MQUsername"];
                var password = s.GetRequiredService<IConfiguration>()["MQPassword"];


                ActiveMQLog result = new ActiveMQLog(uri, username, password);
                return result;
            });

             _configurationSetting = services.RegisterConfiguration(Configuration);
            services.AddConsulConfig(_configurationSetting);

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyOrigin()
                       .AllowAnyMethod()
                       .AllowAnyHeader();
            }));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseConsul(_configurationSetting);

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseCors("MyPolicy");

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
