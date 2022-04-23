using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
	public class Singleton<T> where T : class, new()
	{
		private static readonly object Sync = new object();
		private static T instance = null;
		public static T Instance
		{
			get 
			{
				if (instance == null)
				{
					lock (Sync)
					{
						if (instance == null)
						{
							instance = new T();
						}
					}
				}
				return instance;
			}
		}
	}
}
