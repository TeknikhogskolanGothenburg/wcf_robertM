using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.ServiceModel.Description;
using static System.Console;

namespace Host
{
	class Program
	{
		static void Main()
		{
			#region Define the rest host
			WebServiceHost restHost = new WebServiceHost(typeof(Service.CarRentalServiceREST),
				new Uri("http://localhost:8080"));

			ServiceEndpoint ep = restHost.AddServiceEndpoint(
				typeof(Service.ICarRentalServiceREST), new WebHttpBinding(), "");

			restHost.Description.Endpoints[0].Behaviors.Add(new WebHttpBehavior { HelpEnabled = true });

			ServiceDebugBehavior sdb = restHost.Description.Behaviors.Find<ServiceDebugBehavior>();

			sdb.IncludeExceptionDetailInFaults = true;
			//sdb.HttpsHelpPageEnabled = true;
			#endregion

			//In this case I think it's okay to launch both services from one place
			//their addresses are hosted localy on different ports so no collision happens
			using (ServiceHost WCFhost = new ServiceHost(typeof(Service.CarRentalService)))
			{
				WCFhost.Open();
				WriteLine("WCF host is live");
				restHost.Open();
				WriteLine("REST host is live");
				ReadLine();
			}
		}
	}
}
