using System;
using System.Collections.Generic;
using System.Text;

namespace Pather.Graph
{
	class SpotData<T>
	{
		Dictionary<Spot, T> data = new Dictionary<Spot, T>();

		public T Get(Spot s)
		{
			T t = default(T);
			data.TryGetValue(s, out t);
			return t;
		}

		public void Set(Spot s, T t)
		{
			if (data.ContainsKey(s))
				data.Remove(s);
			data.Add(s, t);
		}

		public bool IsSet(Spot s)
		{
			return data.ContainsKey(s);
		}

	}
}
