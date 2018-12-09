﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.Serialization;

namespace Context
{
	[DataContract]
    public class Customer
    {
        public Customer()
        {
            Reservations = new List<Reservation>();
        }
		[DataMember]
        public int Id { get; set; }
		[DataMember]
        public string FirstName { get; set; }
		[DataMember]
        public string LastName { get; set; }
		[DataMember]
        public string  Phone { get; set; }
		[DataMember]
        public string Email { get; set; }
		[DataMember]
        public List<Reservation> Reservations { get; set; }
    }
}
