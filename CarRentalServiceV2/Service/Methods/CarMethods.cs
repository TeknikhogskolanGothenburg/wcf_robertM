using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Context;

namespace Service
{
	public class CarMethods
	{
		static private Context.Context _context = new Context.Context();

		public bool AddCar(Car car)
		{
			try
			{
				_context.Cars.Add(car);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				var ex = new NoDataAvaliable {
					Info = "Couldn't add car"
				};
				throw new FaultException<NoDataAvaliable>(ex);
			}
			return true;
		}

		public bool DeleteCar(Car car)
		{
			try
			{
				_context.Cars.Remove(car);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				var ex = new NoDataAvaliable
				{
					Info = "Couldn't delete car"
				};
				throw new FaultException<NoDataAvaliable>(ex);
			}
			return true;
		}

		public List<Car> GetAllCars()
		{
			var cars = _context.Cars.ToList();
			if(cars.Count <= 0)
			{
				NoDataAvaliable ex = new NoDataAvaliable
				{
					Info = string.Format("No cars in the database")
				};
				throw new FaultException<NoDataAvaliable>(ex);
			}
			return cars;
		}

		public Car GetCarById(int id)
		{
			var car = _context.Cars.Where(x => x.Id == id).FirstOrDefault();
			if (car == null)
			{
				NoDataAvaliable ex = new NoDataAvaliable
				{
					Info = string.Format("Couldn't find a car with the Id: {0}", id)
				};
				throw new FaultException<NoDataAvaliable>(ex);
			}
			return car;
		}

		public CarResult GetCarByRegnum(CarRequest request)
		{
			if (request.LicenseKey != "yggdrasil")
			{
				AccessDenied ex = new AccessDenied
				{
					Info = "Password was wrong"
				};
				throw new FaultException<AccessDenied>(ex);
			}
			var car = _context.Cars.Where(x => x.Regnumber == request.Regnumber).FirstOrDefault();
			if (car == null)
			{
				NoDataAvaliable ex = new NoDataAvaliable
				{
					Info = string.Format("Couldn't find a car with the Regnum: {0}", request.Regnumber)
				};
				throw new FaultException<NoDataAvaliable>(ex);
			}
			return new CarResult(car);
		}

		public Car GetCarByRegnumREST(string regnumber)
		{
			var car = _context.Cars.Where(x => x.Regnumber == regnumber).FirstOrDefault();
			if (car == null)
			{
				NoDataAvaliable ex = new NoDataAvaliable
				{
					Info = string.Format("Couldn't find a car with the Regnum: {0}", regnumber)
				};
				throw new FaultException<NoDataAvaliable>(ex);
			}
			return car;
		}
	}
}
