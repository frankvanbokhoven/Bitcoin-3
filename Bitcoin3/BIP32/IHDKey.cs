using System;
using System.Collections.Generic;
using System.Text;

namespace Bitcoin3
{
	public interface IHDKey
	{
		IHDKey Derive(KeyPath keyPath);
		PubKey GetPublicKey();
		bool CanDeriveHardenedPath();
	}
}
