using System.Runtime.Serialization;

namespace Context
{
	/// <summary>
	/// In case service couldn't add or delete something
	/// hence "AD" acronym
	/// </summary>
	[DataContract(Namespace="http://audhumbla.xyz/FaultContracts/ADContract")]
	public class ADContract
	{
		[DataMember]
		public string Info { get; set; }
	}
}
