using System.Runtime.Serialization;

namespace Context
{
	/// <summary>
	/// In case the database is empty or your search
	/// returns no result
	/// </summary>
	[DataContract(Namespace="http://audhumbla.xyz/FaultContracts/NoDataAvaliable")]
	public class NoDataAvaliable
	{
		[DataMember]
		public string Info { get; set; }
	}
}
