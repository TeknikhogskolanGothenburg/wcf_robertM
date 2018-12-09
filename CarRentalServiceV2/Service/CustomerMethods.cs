using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
				return false;
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
				return false;
			}
			return true;
		}

		public List<Customer> GetAllCustomers()
		{
			return _context.Customers.ToList();
		}
	}
}
