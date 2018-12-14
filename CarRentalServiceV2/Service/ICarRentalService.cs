using System.Runtime.Serialization;
using System.ServiceModel;
using System.Net.Security;
using Context;
using System.Collections.Generic;
using System;

namespace Service
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICarRentalService" in both code and config file together.
	[ServiceContract]
	public interface ICarRentalService
	{
		#region Car Methods
		[OperationContract]
		[FaultContract(typeof(NoDataAvaliable))]
		List<Car> GetAllCars();

		[OperationContract]
		[FaultContract(typeof(NoDataAvaliable))]
		Car GetCarById(int id);

		[OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
		[FaultContract(typeof(AccessDenied))]
		[FaultContract(typeof(NoDataAvaliable))]
		CarResult GetCarByRegnum(CarRequest request);

		[OperationContract(ProtectionLevel = ProtectionLevel.None)]
		[FaultContract(typeof(NoDataAvaliable))]
		bool AddCar(Car car);

		[OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
		[FaultContract(typeof(AccessDenied))]
		[FaultContract(typeof(NoDataAvaliable))]
		bool DeleteCar(Car car);

		#endregion

		#region Customer Methods
		[OperationContract]
		[FaultContract(typeof(NoDataAvaliable))]
		List<Customer> GetAllCustomers();

		[OperationContract]
		[FaultContract(typeof(ADContract))]
		bool AddCustomer(Customer customer);

		[OperationContract]
		[FaultContract(typeof(ADContract))]
		bool DeleteCustomer(Customer customer);
		#endregion

		#region Reservation Methods
		[OperationContract]
		[FaultContract(typeof(NoDataAvaliable))]
		List<Reservation> GetAllReservations();

		[OperationContract]
		[FaultContract(typeof(NoDataAvaliable))]
		List<Car> GetAvaibleCars(DateTime start, DateTime end);

		[OperationContract]
		[FaultContract(typeof(ADContract))]
		bool AddReservation(Reservation reservation);

		[OperationContract]
		[FaultContract(typeof(ADContract))]
		bool DeleteReservation(Reservation reservation);

		[OperationContract]
		[FaultContract(typeof(ADContract))]
		bool FinishReservation(Reservation reservation);
		#endregion
	}
}
