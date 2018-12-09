using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Context;

namespace Service
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarRentalService" in both code and config file together.
	[ServiceContract]
	public interface ICarRentalService
	{
		#region Car Methods
		[OperationContract]
		[WebInvoke(Method = "POST",
			UriTemplate = "AddCar",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Wrapped)]
		bool AddCar(Car car);

		[OperationContract]
		[WebInvoke(Method = "POST",
			UriTemplate = "RemoveCar",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Wrapped)]
		bool DeleteCar(Car car);

		#endregion

		#region Customer Methods
		[OperationContract]
		[WebInvoke(Method = "POST",
			UriTemplate = "AddCustomer",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Wrapped)]
		bool AddCustomer(Customer customer);
		[OperationContract]
		[WebInvoke(Method = "POST",
			UriTemplate = "RemoveCustomer",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Wrapped)]
		bool DeleteCustomer(Customer customer);
		#endregion

		#region Reservation Methods
		[OperationContract]
		[WebInvoke(Method = "POST",
			UriTemplate = "AddReservation",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Wrapped)]
		bool AddReservation(Reservation reservation);

		[OperationContract]
		[WebInvoke(Method = "POST",
			UriTemplate = "RemoveReservation",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Wrapped)]
		bool DeleteReservation(Reservation reservation);

		[OperationContract]
		[WebInvoke(Method = "POST",
			UriTemplate = "FinishReservation",
			RequestFormat = WebMessageFormat.Json,
			ResponseFormat = WebMessageFormat.Json,
			BodyStyle = WebMessageBodyStyle.Wrapped)]
		bool FinishReservation(Reservation reservation);
		#endregion
	}

	//For the rest api I will add all the get options
	[ServiceContract]
	public interface ICarRentalServiceGET
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
			BodyStyle = WebMessageBodyStyle.Wrapped)]
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

	[DataContract]
	public class CompositeType
	{
		bool boolValue = true;
		string stringValue = "Hello ";

		[DataMember]
		public bool BoolValue
		{
			get { return boolValue; }
			set { boolValue = value; }
		}

		[DataMember]
		public string StringValue
		{
			get { return stringValue; }
			set { stringValue = value; }
		}
	}
}
