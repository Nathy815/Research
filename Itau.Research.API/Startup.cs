using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Itau.Research.Domain.Interfaces;
using Itau.Research.Infra.Data;
using Itau.Research.Infra.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace Itau.Research.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddDbContext<SqlContext>(options => options.UseSqlServer(
                Configuration.GetConnectionString("SqlServerConnection")))
                    .AddTransient<ISegment, SegmentRepository>()
                    .AddTransient<ITier, TierRepository>()
                    .AddTransient<IEvent, EventRepository>()
                    .AddTransient<ITrack, TrackRepository>()
                    .AddTransient<ICategory, CategoryRepository>()
                    .AddTransient<IInterest, InterestRepository>()
                    .AddTransient<IUser, UserRepository>()
                    .AddTransient<IScore, ScoreRepository>()
                    .AddTransient<IReport, ReportRepository>();

            services.AddCors(o => o.AddPolicy("MyPolicy", builder =>
            {
                builder.AllowAnyHeader()
                       .AllowAnyMethod()
                       .AllowAnyOrigin();
            }));

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env, SqlContext context)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();

                app.UseCors(builder =>
                {
                    builder.AllowAnyHeader()
                           .AllowAnyMethod()
                           .AllowAnyOrigin();
                });
            }
            else
            {
                app.UseHsts();
            }

            app.UseCors();
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
