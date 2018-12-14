using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using Context;

namespace Service
{
	// NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "CarRentalService" in both code and config file together.
	public class CarRentalService : ICarRentalService
	{
		static private CarMethods _carMethods = new CarMethods();
		static private CustomerMethods _customerMethods = new CustomerMethods();
		static private ReservationMethods _reservationMethods = new ReservationMethods();
		static private Context.Context _context = new Context.Context();

		#region Car Methods
		public List<Car> GetAllCars()
		{
			return _carMethods.GetAllCars();
		}

		public Car GetCarById(int id)
		{
			return _carMethods.GetCarById(id);
		}

		public CarResult GetCarByRegnum(CarRequest request)
		{
			return _carMethods.GetCarByRegnum(request);
		}

		public bool AddCar(Car car)
		{
			return _carMethods.AddCar(car);
		}

		public bool DeleteCar(Car car)
		{
			return _carMethods.DeleteCar(car);
		}
		#endregion

		#region Customer Methods
		public List<Customer> GetAllCustomers()
		{
			return _customerMethods.GetAllCustomers();
		}
		public bool AddCustomer(Customer customer)
		{
			return _customerMethods.AddCustomer(customer);
		}
		public bool DeleteCustomer(Customer customer)
		{
			return _customerMethods.DeleteCustomer(customer);
		}
		#endregion

		#region Reservation Methods
		public List<Reservation> GetAllReservations()
		{
			return _reservationMethods.GetAllReservations();
		}
		public List<Car> GetAvaibleCars(DateTime start, DateTime end)
		{
			return _reservationMethods.GetAvaibleCars(start, end);
		}
		public bool AddReservation(Reservation reservation)
		{
			return _reservationMethods.AddReservation(reservation);
		}
		public bool DeleteReservation(Reservation reservation)
		{
			return _reservationMethods.DeleteReservation(reservation);
		}
		public bool FinishReservation(Reservation reservation)
		{
			return _reservationMethods.FinishReservation(reservation);
		}
		#endregion
	}
}
