using System;
using System.Collections.Generic;
using System.Text;

namespace Bitcoin3
{
    public interface IHasForkId
    {
		uint ForkId
		{
			get;
		}
    }
}
