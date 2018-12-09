using Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
	[ServiceContract]
	public interface ICarRentalServiceREST
	{
		#region Car Methods
		[OperationContract]
		[WebGet(UriTemplate = "Cars",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		List<Car> GetAllCars();

		[OperationContract]
		[WebInvoke(Method = "POST",
			UriTemplate = "GetCarByRegnum",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.WrappedRequest)]
		Car GetCarByRegnum(string regnumber);
		#endregion

		#region Customer Methods
		[OperationContract]
		[WebGet(UriTemplate = "Customers",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		List<Customer> GetAllCustomers();
		#endregion

		#region Reservation Methods
		[OperationContract]
		[WebGet(UriTemplate = "Reservations",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json)]
		List<Reservation> GetAllReservations();

		[OperationContract]
		[WebInvoke(Method = "POST",
			UriTemplate = "GetAvaibleCars",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Wrapped)]
		List<Car> GetAvaibleCars(DateTime start, DateTime end);
		#endregion
	}
}
