using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitcoin3.Protocol
{
	[Payload("verack")]
	public class VerAckPayload : Payload, IBitcoinSerializable
	{
		#region IBitcoinSerializable Members

		public override void ReadWriteCore(BitcoinStream stream)
		{
		}

		#endregion
	}
}
