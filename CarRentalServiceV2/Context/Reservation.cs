using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System.Collections.Generic;
using System.Text;

namespace Context
{
	[DataContract]
    public class Reservation
    {
		[DataMember]
        public int Id { get; set; }

		[DataMember]
        [ForeignKey("Car")]
        public int CarId { get; set; }
		[DataMember]
        public Car Car { get; set; }

		[DataMember]
        [ForeignKey("Customer")]
        public int CustomerId { get; set; }
		[DataMember]
        public Customer Customer { get; set; }

		[DataMember]
		public bool Returned { get; set; }
		[DataMember]
		public DateTime StartDate { get; set; }
		[DataMember]
        public DateTime EndDate { get; set; }
    }
}
