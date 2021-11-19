using Autofac;
using Autofac.Integration.Mvc;
using Autofac.Integration.WebApi;
using RetroLogger5000.Data.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace RetroLogger5000.Web
{
	public class ContainerConfig
	{
		internal static void RegisterContainer(HttpConfiguration httpconfiguration)
		{
			var builder = new ContainerBuilder();

			builder.RegisterControllers(typeof(MvcApplication).Assembly);
			builder.RegisterApiControllers(typeof(MvcApplication).Assembly);

			builder.RegisterType<InMemoryGameData>()
				.As<IGameData>()
				.SingleInstance();

			var container = builder.Build();
			DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
			httpconfiguration.DependencyResolver = new AutofacWebApiDependencyResolver(container);
		}
	}
}