using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ABClient.Helpers;

public static class Misc
{
	public static object DeepClone(object obj)
	{
		MemoryStream memoryStream = new MemoryStream();
		try
		{
			BinaryFormatter binaryFormatter = new BinaryFormatter();
			binaryFormatter.Serialize(memoryStream, obj);
			memoryStream.Position = 0L;
			return binaryFormatter.Deserialize(memoryStream);
		}
		finally
		{
			((IDisposable)memoryStream).Dispose();
		}
	}
}
