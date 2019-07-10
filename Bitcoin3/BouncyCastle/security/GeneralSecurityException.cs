using System;

namespace Bitcoin3.BouncyCastle.Security
{
	internal class GeneralSecurityException
		: Exception
	{
		public GeneralSecurityException()
			: base()
		{
		}

		public GeneralSecurityException(
			string message)
			: base(message)
		{
		}

		public GeneralSecurityException(
			string message,
			Exception exception)
			: base(message, exception)
		{
		}
	}
}
