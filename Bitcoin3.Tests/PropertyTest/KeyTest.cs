using FsCheck;
using FsCheck.Xunit;
using Bitcoin3.Tests.Generators;
using Bitcoin3;
using Xunit;
using System.Collections.Generic;
using System.Linq;

namespace Bitcoin3.Tests.PropertyTest
{
	public class KeyTest
	{
		public KeyTest()
		{
			Arb.Register<CryptoGenerator>();
			Arb.Register<ChainParamsGenerator>();
		}

		[Property]
		[Trait("UnitTest", "UnitTest")]
		public bool CanSerializeAsymmetric(Key key, Network network)
		{
			var keyStr = key.ToString();
			string wif = new BitcoinSecret(key, network).ToWif();
			return Key.Parse(wif, network).Equals(key);
		}

		[Property(MaxTest = 10)]
		[Trait("PropertyTest", "Verification")]
		public bool ShouldNotGenerateSameKey(List<Key> keys)
		{
			return keys.Distinct().Count() == keys.Count();
		}

	}
}