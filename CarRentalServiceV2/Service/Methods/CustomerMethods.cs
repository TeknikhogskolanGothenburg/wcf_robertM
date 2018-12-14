using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using Context;

namespace Service
{
	public class CustomerMethods
	{
		static private Context.Context _context = new Context.Context();

		public bool AddCustomer(Customer customer)
		{
			try
			{
				_context.Customers.Add(customer);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				var ex = new ADContract
				{
					Info = "Couldn't add customer"
				};
				throw new FaultException<ADContract>(ex);
			}
			return true;
		}

		public bool DeleteCustomer(Customer customer)
		{
			try
			{
				_context.Customers.Remove(customer);
				_context.SaveChanges();
			}
			catch (Exception)
			{
				var ex = new ADContract
				{
					Info = "Couldn't delete customer"
				};
				throw new FaultException<ADContract>(ex);
			}
			return true;
		}

		public List<Customer> GetAllCustomers()
		{
			var customes = _context.Customers.ToList();
			if(customes.Count <= 0)
			{
				var ex = new NoDataAvaliable
				{
					Info = "No customers in the database"
				};
				throw new FaultException<NoDataAvaliable>(ex);
			}
			return customes;
		}
	}
}
