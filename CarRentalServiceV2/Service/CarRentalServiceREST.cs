using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Context;

namespace Service
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarRentalService" in both code and config file together.
	public class CarRentalServiceREST : ICarRentalServiceREST
	{
		static private CarMethods _carMethods = new CarMethods();
		static private CustomerMethods _customerMethods = new CustomerMethods();
		static private ReservationMethods _reservationMethods = new ReservationMethods();

		public List<Car> GetAllCars()
		{
			return _carMethods.GetAllCars();
		}

		public List<Customer> GetAllCustomers()
		{
			return _customerMethods.GetAllCustomers();
		}

		public List<Reservation> GetAllReservations()
		{
			return _reservationMethods.GetAllReservations();
		}

		public List<Car> GetAvaibleCars(DateTime start, DateTime end)
		{
			return _reservationMethods.GetAvaibleCars(start, end);
		}

		public Car GetCarByRegnum(string regnumber)
		{
			return _carMethods.GetCarByRegnumREST(regnumber);
		}
	}
}
