﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Context;

namespace Service
{
	public class ReservationMethods
	{
		static private Context.Context _context = new Context.Context();

		public bool AddReservation(Reservation reservation)
		{
			try
			{
				_context.Reservations.Add(reservation);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				var ex = new ADContract
				{
					Info = "Couldn't add reservation"
				};
				throw new FaultException<ADContract>(ex);
			}
			return true;
		}

		public bool DeleteReservation(Reservation reservation)
		{
			try
			{
				_context.Reservations.Remove(reservation);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				var ex = new ADContract
				{
					Info = "Couldn't delete reservation"
				};
				throw new FaultException<ADContract>(ex);
			}
			return true;
		}

		public List<Reservation> GetAllReservations()
		{
			var reservations = _context.Reservations.ToList();
			if (reservations.Count <= 0)
			{
				var ex = new NoDataAvaliable
				{
					Info = "No customers in the database"
				};
				throw new FaultException<NoDataAvaliable>(ex);
			}
			return reservations;
		}

		public List<Car> GetAvaibleCars(DateTime start, DateTime end)
		{
			//This gets the cars that arent booked
			var allInUseCars = _context.Reservations.Select(x => x.Car).AsQueryable();
			var allCars = _context.Cars.Where(x => x.Id > 0).AsQueryable();
			var allAvaibleCars = allCars.Except(allInUseCars).ToList();

			if (allAvaibleCars.Any())
			{
				return allAvaibleCars;
			}
			else
			{
				//Get any cars that are avaible after the start date
				var avaibleCars = _context.Reservations.Where(x => x.EndDate < start).ToList();
				if (avaibleCars.Any())
				{
					return avaibleCars.Select(x => x.Car).ToList();
				}
			}
			return new List<Car>();
		}

		public bool FinishReservation(Reservation _reservation)
		{
			var reservation = _context.Reservations.Find(_reservation);
			if (reservation.Id == 0)
				return false;
			try
			{
				reservation.Returned = true;
				_context.SaveChanges();
			}
			catch (Exception)
			{
				var ex = new ADContract
				{
					Info = "Couldn't finish reservation"
				};
				throw new FaultException<ADContract>(ex);
			}
			return true;
		}
	}
}
