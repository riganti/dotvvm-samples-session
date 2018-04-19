using System;
using System.Web;
using System.Web.Hosting;
using System.Web.SessionState;
using Microsoft.Owin;
using Microsoft.Owin.FileSystems;
using Microsoft.Owin.StaticFiles;
using Owin;
using DotVVM.Framework;
using DotVVM.Framework.Configuration;
using DotVVM.Framework.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Owin.Extensions;
using Microsoft.Owin.Infrastructure;

[assembly: OwinStartup(typeof(DotvvmSessionSample.Startup))]
namespace DotvvmSessionSample
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.Use((context, next) =>
            {
                var httpContext = context.Get<HttpContextBase>(typeof(HttpContextBase).FullName);
                httpContext.SetSessionStateBehavior(SessionStateBehavior.Required);
                return next();
            });
            app.UseStageMarker(PipelineStage.MapHandler);


            var applicationPhysicalPath = HostingEnvironment.ApplicationPhysicalPath;

            ConfigureAuth(app);

            // use DotVVM
            var dotvvmConfiguration = app.UseDotVVM<DotvvmStartup>(applicationPhysicalPath, debug: IsInDebugMode(), options: options =>
            {
                options.AddDefaultTempStorages("temp");

                options.Services.AddSingleton<ICookieManager, SystemWebCookieManager>();
            });


            // use static files
            app.UseStaticFiles(new StaticFileOptions()
            {
                FileSystem = new PhysicalFileSystem(applicationPhysicalPath)
            });
        }
        public void ConfigureAuth(IAppBuilder app)
        {
        }

		private bool IsInDebugMode()
        {
#if !DEBUG
			return false;
#endif
            return true;
        }
    }
}
