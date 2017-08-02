namespace MvcForum.Web.Ui
{
    using System;
    using Core.Models.Settings;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Http;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;
    using Microsoft.Extensions.Logging;
    using Microsoft.Extensions.Options;

    public class Startup
    {
        private readonly IConfigurationRoot _configurationRoot;
        private readonly IHostingEnvironment _hostingEnvironment;
        private readonly IServiceProvider _serviceProvider;

        public Startup(IHostingEnvironment hostingEnvironment, IServiceProvider serviceProvider)
        {
            _configurationRoot = new ConfigurationBuilder()
                .SetBasePath(hostingEnvironment.ContentRootPath)
                .AddJsonFile("appsettings.json", true, true)
                .AddEnvironmentVariables()
                .Build();

            _serviceProvider = serviceProvider;
            _hostingEnvironment = hostingEnvironment;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            // Gab Settings In Request Scope
            services.Configure<MvcForumConfig>(_configurationRoot.GetSection("MvcForumConfig"));
            services.AddScoped(cfg => cfg.GetService<IOptionsSnapshot<MvcForumConfig>>().Value);

            // Grab the settings for use in this method
            var settings = _configurationRoot.GetSection("GabSettings").Get<MvcForumConfig>();

            //// The main DB content
            //services.AddDbContext<GabDbContext>(
            //    options => options.UseSqlServer(_configurationRoot.GetConnectionString("GabConnection")));

            //// Set up to use ASP.NET Identity
            //services.AddIdentity<GabUser, GabRole>()
            //    .AddEntityFrameworkStores<GabDbContext, Guid>()
            //    .AddDefaultTokenProviders()
            //    .AddUserStore<UserStore<GabUser, GabRole, GabDbContext, Guid>>()
            //    .AddRoleStore<RoleStore<GabRole, GabDbContext, Guid>>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            loggerFactory.AddConsole();

            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.Run(async context => { await context.Response.WriteAsync("Hello World!"); });
        }
    }
}