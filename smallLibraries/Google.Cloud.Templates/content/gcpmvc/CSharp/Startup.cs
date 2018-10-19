#if Framework1
using Google.Cloud.Diagnostics.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using System;
using System.IO;

namespace MyGcpMvcProject
{
    public class Startup
    {
        public IConfigurationRoot Configuration { get; }

        private readonly Lazy<string> _projectIdLazy;
        private string ProjectId => _projectIdLazy.Value ?? "";
        private bool HasProjectId => _projectIdLazy.Value != null;

        public Startup(IHostingEnvironment env)
        {
            _projectIdLazy = new Lazy<string>(GetProjectId);
            var builder = new ConfigurationBuilder()
                .SetBasePath(env.ContentRootPath)
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile($"appsettings.{env.EnvironmentName}.json", optional: true)
                .AddEnvironmentVariables();
            Configuration = builder.Build();
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // Add framework services.Microsoft.VisualStudio.ExtensionManager.ExtensionManagerService
            services.AddMvc();

            if (HasProjectId)
            {
                // Enables Stackdriver Trace.
                services.AddGoogleTrace(options => options.ProjectId = ProjectId);
                // Sends Exceptions to Stackdriver Error Reporting.
                services.AddGoogleExceptionLogging(
                    options => {
                        options.ProjectId = ProjectId;
                        options.ServiceName = GetServiceName();
                        options.Version = GetVersion();
                    });
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {

            if (env.IsDevelopment())
            {
                // Only use Console and Debug logging during development.
                loggerFactory.AddConsole(Configuration.GetSection("Logging"));
                loggerFactory.AddDebug();

                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
                app.UseStaticFiles(new StaticFileOptions {
                    FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "node_modules")),
                    RequestPath = new PathString("/lib")
                });
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                if (HasProjectId)
                {
                    // Send logs to Stackdriver Logging.
                    loggerFactory.AddGoogle(ProjectId);
                    // Sends logs to Stackdriver Error Reporting.
                    app.UseGoogleExceptionLogging();
                    // Sends logs to Stackdriver Trace.
                    app.UseGoogleTrace();

                    var startupLogger = loggerFactory.CreateLogger<Startup>();
                    startupLogger.LogInformation(
                        "Stackdriver Logging enabled: https://console.cloud.google.com/logs/");
                    startupLogger.LogInformation(
                        "Stackdriver Error Reporting enabled: https://console.cloud.google.com/errors/");
                    startupLogger.LogInformation(
                        "Stackdriver Trace not enabled: https://console.cloud.google.com/traces/");
                }
                else
                {
                    var startupLogger = loggerFactory.CreateLogger<Startup>();
                    startupLogger.LogWarning(
                        "Stackdriver Logging not enabled. Missing Google:ProjectId in configuration.");
                    startupLogger.LogWarning(
                        "Stackdriver Error Reporting not enabled. Missing Google:ProjectId in configuration.");
                    startupLogger.LogWarning(
                        "Stackdriver Trace not enabled. Missing Google:ProjectId in configuration.");
                }
            }

            app.UseStaticFiles();

            app.UseMvc(routes => {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }

        private string GetProjectId()
        {
            var instance = Google.Api.Gax.Platform.Instance();
            var projectId = instance?.ProjectId ?? Configuration["Google:ProjectId"];
            if (string.IsNullOrEmpty(projectId))
            {
                // Set Google:ProjectId in appsettings.json to enable stackdriver logging outside of GCP.
                return null;
            }
            return projectId;
        }

        private string GetServiceName()
        {
            var instance = Google.Api.Gax.Platform.Instance();
            // An identifier of the service. See https://cloud.google.com/error-reporting/docs/formatting-error-messages#FIELDS.service.
            var serviceName =
                instance?.GaeDetails?.ServiceId ??
                Configuration["Google:ErrorReporting:ServiceName"];
            if (string.IsNullOrEmpty(serviceName))
            {
                throw new Exception(
                    "The error reporting library needs a service name. " +
                    "Update appsettings.json by setting the Google:ErrorReporting:ServiceName property with your " +
                    "Service Id, then recompile.");
            }
            return serviceName;
        }

        private string GetVersion()
        {
            var instance = Google.Api.Gax.Platform.Instance();
            // The source version of the service. See https://cloud.google.com/error-reporting/docs/formatting-error-messages#FIELDS.version.
            var versionId =
                instance?.GaeDetails?.VersionId ??
                Configuration["Google:ErrorReporting:Version"];
            if (string.IsNullOrEmpty(versionId))
            {
                throw new Exception(
                    "The error reporting library needs a version id. " +
                    "Update appsettings.json by setting the Google:ErrorReporting:Version property with your " +
                    "service version id, then recompile.");
            }
            return versionId;
        }
    }
}
#endif
