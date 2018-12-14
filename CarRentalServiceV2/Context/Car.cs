using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.ServiceModel;

namespace Context
{
	[DataContract]
    public class Car
    {
		[DataMember]
        public int Id { get; set; } 
		[DataMember]
        public string Brand { get; set; }
		[DataMember]
        public string Model { get; set; }
		[DataMember]
        public int Year { get; set; }
		[DataMember]
        public string Regnumber { get; set; }
	}

	#region Message Contracts
	[MessageContract(IsWrapped = true,
		WrapperName = "CarInfoObject",
		WrapperNamespace="http://audhumbla.xyz/DataContracts/Car")]
	public class CarResult
	{
		public CarResult() { }
		public CarResult(Car car)
		{
			this.Id = car.Id;
			this.Brand = car.Brand;
			this.Model = car.Model;
			this.Year = car.Year;
			this.Regnumber = car.Regnumber;
		}

		[MessageBodyMember(Order = 1, Namespace="http://audhumbla.xyz/DataContracts/Car")]
		public int Id { get; set; }
		[MessageBodyMember(Order = 2, Namespace="http://audhumbla.xyz/DataContracts/Car")]
		public string Brand { get; set; }
		[MessageBodyMember(Order = 3, Namespace="http://audhumbla.xyz/DataContracts/Car")]
		public string Model { get; set; }
		[MessageBodyMember(Order = 4, Namespace="http://audhumbla.xyz/DataContracts/Car")]
		public int Year { get; set; }
		[MessageBodyMember(Order = 5, Namespace="http://audhumbla.xyz/DataContracts/Car")]
		public string Regnumber { get; set; }
	}

	[MessageContract(IsWrapped = true,
		WrapperName = "CarRequestObject",
		WrapperNamespace="http://audhumbla.xyz/DataContracts/Car")]
	public class CarRequest
	{
		[MessageBodyMember(Order = 1, Namespace="http://audhumbla.xyz/DataContracts/Car")]
		public string LicenseKey { get; set; }
		[MessageBodyMember(Order = 2, Namespace="http://audhumbla.xyz/DataContracts/Car")]
		public string Regnumber { get; set; }
	}
	#endregion
}
