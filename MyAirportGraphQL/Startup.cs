using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GraphQL;
using GraphQL.Types;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using MyAirport.GraphQL;
using MyAirport.GraphQL.Type;
using PSB.MyAirport.EF;

namespace PSB.MyAirport.GraphQL
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            //services.AddScoped<iDependencyResolver>(x => new FuncDependencyResolver(x.GetRequiredService));
            services.AddSingleton<AirportQuery>();
            services.AddSingleton<AirportSchema>();
            services.AddSingleton<BagageType>();
            services.AddSingleton<VolType>();
            services.AddDbContext<MyAirportContext>(option => option.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Airport;Integrated Security=True"));

            services.AddControllers();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseGraphiQLServer(new GraphQL.Server.Ui.GraphiQL.GraphiQLOptions { GraphiQLPath = "/api/graphql" });

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
