using System.Collections.Generic;
using FsCheck;
using Bitcoin3;
namespace Bitcoin3.Tests.Generators
{
	public class StandardScriptGenerator
	{
		public static Gen<Script> FromKey(PubKey key)
		{
			return Gen.Constant(new Script());
		}
	}
}