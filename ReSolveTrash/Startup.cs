[assembly: Microsoft.Owin.OwinStartup(typeof(ReSolveTrash.Startup))]
namespace ReSolveTrash
{
    using Microsoft.Owin;
    using Microsoft.Owin.Security.OAuth;
    using Owin;
    using ReSolveTrash.Providers;
    using System;
    using System.Web.Http;
    using System.Web.Http.Cors;
    using System.Web.Routing;

    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            HttpConfiguration config = new HttpConfiguration();

            WebApiConfig.Register(config);
            SwaggerConfig.Register(config);
            
            WebConfig.Register(RouteTable.Routes);

            app.UseOAuthAuthorizationServer(new OAuthAuthorizationServerOptions()
            {
                AllowInsecureHttp = true,
                TokenEndpointPath = new PathString("/token"),
                AccessTokenExpireTimeSpan = TimeSpan.FromHours(3),
                Provider = new AuthorizationServerProvider()
            });
            config.EnableCors(new EnableCorsAttribute("*", "*", "*"));

            app.UseOAuthBearerAuthentication(new OAuthBearerAuthenticationOptions());
            app.UseWebApi(config);


        }
    }
}
