using System.IO;

namespace Bitcoin3.BouncyCastle.Asn1
{
	internal interface Asn1OctetStringParser
		: IAsn1Convertible
	{
		Stream GetOctetStream();
	}
}
