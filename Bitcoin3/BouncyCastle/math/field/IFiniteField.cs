namespace Bitcoin3.BouncyCastle.Math.Field
{
	internal interface IFiniteField
	{
		BigInteger Characteristic
		{
			get;
		}

		int Dimension
		{
			get;
		}
	}
}
