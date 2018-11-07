﻿using Autofac;
using Autofac.Integration.WebApi;
using Microsoft.Owin.Hosting;
using Owin;
using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Web.Http;

namespace InjectRoute
{
    internal class Program
    {
        private const string SearchPath = "Services";

        private static void Main(string[] args)
        {
            string baseAddress = "http://localhost:9002/";
            using (WebApp.Start<Startup>(url: baseAddress))
            {
                Console.WriteLine("App Server started.");
                Console.ReadLine();
            }
        }

        internal class Startup
        {
            public void Configuration(IAppBuilder appBuilder)
            {
                //定义Autofac容器创建器
                var builder = new ContainerBuilder();

                //注入Api服务
                BuildControllers(builder);

                //生成Autofac容器
                var container = builder.Build();

                //在Owin管道中加入Autofac中间件
                appBuilder.UseAutofacMiddleware(container);

                HttpConfiguration config = new HttpConfiguration();
                config.DependencyResolver = new AutofacWebApiDependencyResolver(container);

                config.MapHttpAttributeRoutes();
                config.Routes.MapHttpRoute(
                   name: "DefaultApi",
                   routeTemplate: "api/{controller}/{id}",
                   defaults: new { id = RouteParameter.Optional }
                );

                appBuilder.UseAutofacWebApi(config);
                appBuilder.UseWebApi(config);
            }

            private void BuildControllers(ContainerBuilder builder)
            {
                var searchFolder = Path.Combine(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location), SearchPath);

                foreach (var file in Directory.EnumerateFiles(searchFolder, "*.dll", SearchOption.AllDirectories))
                {
                    try
                    {
                        var assembly = Assembly.LoadFrom(file);
                        var exportedTypes = assembly.GetExportedTypes();

                        if (exportedTypes.Any(t => t.IsSubclassOf(typeof(ApiController))))
                        {
                            Console.WriteLine("Started service " + assembly.FullName);
                            builder.RegisterApiControllers(assembly).InstancePerRequest();
                        }
                    }
                    catch { }
                }
            }
        }
    }
}