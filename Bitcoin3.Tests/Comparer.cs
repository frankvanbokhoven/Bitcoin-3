using System.Collections.Generic;

namespace Bitcoin3.Tests
{
	public static class Comparer
	{
		public class PSBTComparer : EqualityComparer<PSBT>
		{
			public override bool Equals(PSBT a, PSBT b) => a.Equals(b);
			public override int GetHashCode(PSBT psbt) => psbt.GetHashCode();
		}
	}
}