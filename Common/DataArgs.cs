using System.Collections.Generic;

namespace Common
{
	public class DataArgs
	{
		private Dictionary<string, object> data = new Dictionary<string, object>();
		public void Set(string key, object value)
		{
			if (data.ContainsKey(key))
			{
				data[key] = value;
			}
			else
			{ 
				data.Add(key, value);
			}
		}

		public object Get(string key)
		{
			object value;
			data.TryGetValue(key, out value);
			return value;

		}
	}
}
