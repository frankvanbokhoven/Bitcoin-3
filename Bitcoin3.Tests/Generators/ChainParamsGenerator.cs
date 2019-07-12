using System.Collections.Generic;
using FsCheck;
using Bitcoin3;

namespace Bitcoin3.Tests.Generators
{
	public class ChainParamsGenerator
	{

		public static Arbitrary<Network> NetworkArb() =>
			Arb.From(NetworkGen());
		public static Gen<Network> NetworkGen() =>
			Gen.OneOf(new List<Gen<Network>> {
					Gen.Constant(Network.Main),
					Gen.Constant(Network.TestNet),
					Gen.Constant(Network.RegTest)
			});

		public static Gen<NetworkType> NetworkType =>
			NetworkGen().Select(n => n.NetworkType);
	}
}