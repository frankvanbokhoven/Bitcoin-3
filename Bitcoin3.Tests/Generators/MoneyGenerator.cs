using System;
using FsCheck;
using Bitcoin3;
using System.Linq;

namespace Bitcoin3.Tests.Generators
{
	public class MoneyGenerator
	{

		public static Gen<Money> Money() =>
			(from bytes in Gen.ListOf(6, PrimitiveGenerator.RandomByte()) // Make sure we are below 21M
			 select Bitcoin3.Utils.ToUInt64(bytes.Concat(new byte[] { 0, 0 }).ToArray(), true))
			 .Select(u64 => new Money(u64));
	}
}