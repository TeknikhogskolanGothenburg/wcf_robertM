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
		List<Car> GetAllCars();

		[OperationContract]
		Car GetCarById(int id);

		[OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
		CarResult GetCarByRegnum(CarRequest request);

		[OperationContract(ProtectionLevel = ProtectionLevel.None)]
		bool AddCar(Car car);

		[OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
		bool DeleteCar(Car car);

		#endregion

		#region Customer Methods
		[OperationContract]
		List<Customer> GetAllCustomers();

		//[OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
		[OperationContract]
		bool AddCustomer(Customer customer);

		//[OperationContract(ProtectionLevel = ProtectionLevel.Sign)]
		[OperationContract]
		bool DeleteCustomer(Customer customer);
		#endregion

		#region Reservation Methods
		[OperationContract]
		List<Reservation> GetAllReservations();

		[OperationContract]
		List<Car> GetAvaibleCars(DateTime start, DateTime end);

		//[OperationContract(ProtectionLevel = ProtectionLevel.None)]
		[OperationContract]
		bool AddReservation(Reservation reservation);

		//[OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
		[OperationContract]
		bool DeleteReservation(Reservation reservation);

		//[OperationContract(ProtectionLevel = ProtectionLevel.EncryptAndSign)]
		[OperationContract]
		bool FinishReservation(Reservation reservation);
		#endregion
	}
}
