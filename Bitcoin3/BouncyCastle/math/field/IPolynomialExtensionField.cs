namespace Bitcoin3.BouncyCastle.Math.Field
{
	internal interface IPolynomialExtensionField
		: IExtensionField
	{
		IPolynomial MinimalPolynomial
		{
			get;
		}
	}
}
