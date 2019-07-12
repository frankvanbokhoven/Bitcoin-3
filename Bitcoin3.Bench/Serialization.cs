using System;
using Bitcoin3;
using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.IO;
using Bitcoin3.Bench;

namespace Bitcoin3.Bench
{
	[RPlotExporter, RankColumn]
	public class Serialization
	{
		BlockSample Sample;
		[GlobalSetup]
		public void Setup()
		{
			Sample = new BlockSample();
			Sample.Download();
		}

		[Benchmark]
		public void SerializeBigBlock()
		{
			MemoryStream ms = new MemoryStream(Sample.BigBlockBytes.Length + 100);
			var bstream = new BitcoinStream(ms, true);
			Sample.BigBlock.ReadWrite(bstream);
		}

		[Benchmark]
		public void DeserializeBigBlock()
		{
			MemoryStream ms = new MemoryStream(Sample.BigBlockBytes);
			var bstream = new BitcoinStream(ms, false);
			Block.CreateBlock(Network.Main).ReadWrite(bstream);
		}
	}
}