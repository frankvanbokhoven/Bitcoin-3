using Bitcoin3.Policy;

namespace Bitcoin3.Tests.Generators
{
	public class StandardTransactionGenerator
	{
		private static StandardTransactionPolicy _Policy;

		static StandardTransactionGenerator()
		{
			_Policy = new StandardTransactionPolicy();
		}
	}
}