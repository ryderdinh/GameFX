using System.Collections.Generic;
using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "ArrayOfArrayInt", menuName = "Variables/List of ArrayInt")]
	public class ArrayArrayInt : Array<ArrayInt>
	{
		private List<List<int>> _list;

		public string GetValue(ArrayArrayInt value)
		{
			return null;
		}

		public ArrayArrayIntObject GetSOToStruct()
		{
			return null;
		}
	}
}
