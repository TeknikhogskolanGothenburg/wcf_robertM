using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
				return false;
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
				return false;
			}
			return true;
		}

		public List<Car> GetAllCars()
		{
			return _context.Cars.ToList();
		}

		public Car GetCarById(int id)
		{
			return _context.Cars.Where(x => x.Id == id).FirstOrDefault();
		}

		public CarResult GetCarByRegnum(string regnumber)
		{
			var car = _context.Cars.Where(x => x.Regnumber == regnumber).FirstOrDefault();
			if (car.Id <= 0)
				return new CarResult();
			return new CarResult(car);
		}

		public Car GetCarByRegnumREST(string regnumber)
		{
			var car = _context.Cars.Where(x => x.Regnumber == regnumber).FirstOrDefault();
			if (car.Id <= 0)
				return new Car();
			return car;
		}
	}
}
