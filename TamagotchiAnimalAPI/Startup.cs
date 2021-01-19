using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MongoDB.Driver;
using Shared.Extensions.ActiveMQ;
using Shared.Extensions.Consul;
using TamagotchiAnimalAPI.SignalR;
using UserManagement.Config;

namespace TamagotchiAnimalAPI
{
    [ExcludeFromCodeCoverage]
    public class Startup
    {

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
                var uri = s.GetRequiredService<IConfiguration>()["MQUri"];
                var username = s.GetRequiredService<IConfiguration>()["MQUsername"];
                var password = s.GetRequiredService<IConfiguration>()["MQPassword"];


                ActiveMQLog result = new ActiveMQLog(uri, username, password);
                return result;
            });

            _configurationSetting = services.RegisterConfiguration(Configuration);
            services.AddConsulConfig(_configurationSetting);

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder
                    .AllowAnyMethod()
                    .AllowAnyHeader()
                    .SetIsOriginAllowed(origin => true) // allow any origin  
                    .AllowCredentials();               // allow credentials 
            }));

            services.AddSignalR();

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

            app.UseSignalR(routes =>
            {
                routes.MapHub<AnimalValuesHub>("/AnimalValues");
            });
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
                //endpoints.MapHub<AnimalValuesHub>("/AnimalValues");
            });
        }
    }
}
