﻿#if !NOJSONNET
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bitcoin3.JsonConverters
{
	public class LockTimeJsonConverter : JsonConverter
	{
		public override bool CanConvert(Type objectType)
		{
			return objectType == typeof(LockTime) || objectType == typeof(LockTime?);
		}

		public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
		{
			try
			{
				var nullable = objectType == typeof(LockTime?);
				return reader.TokenType == JsonToken.Null
					? (nullable ? null as object : LockTime.Zero) 
					: new LockTime((uint)(long)reader.Value);
			}
			catch
			{
				throw new JsonObjectException("Invalid locktime", reader);
			}
		}

		public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
		{
			if(value != null)
			{
				writer.WriteValue(((LockTime)value).Value);
			}
		}
	}
}
#endif