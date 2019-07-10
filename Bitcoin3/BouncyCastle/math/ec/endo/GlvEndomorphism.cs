namespace Bitcoin3.BouncyCastle.Math.EC.Endo
{
	internal interface GlvEndomorphism
		: ECEndomorphism
	{
		BigInteger[] DecomposeScalar(BigInteger k);
	}
}
