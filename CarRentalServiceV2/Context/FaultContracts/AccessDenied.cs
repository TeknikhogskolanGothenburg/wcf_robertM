using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Context
{
	[DataContract(Namespace="http://audhumbla.xyz/FaultContracts/AccessDenied")]
	public class AccessDenied
	{
		[DataMember]
		public string Info { get; set; }
	}
}
