using System;
using FsCheck;
using FsCheck.Xunit;
using Bitcoin3.Tests.Generators;
using Xunit;

namespace Bitcoin3.Tests.PropertyTest
{
	public class AddressTest
	{
		public AddressTest()
		{
			Arb.Register<AddressGenerator>();
			Arb.Register<ChainParamsGenerator>();
		}

		[Property]
		[Trait("UnitTest", "UnitTest")]
		public bool CanSerializeAsymmetric(Tuple<BitcoinAddress, Network> testcase)
		{
			var addrstr = testcase.Item1.ToString();
			var network = testcase.Item2;
			var addr2 = BitcoinAddress.Create(addrstr, network);

			return addrstr == addr2.ToString();
		}
	}
}