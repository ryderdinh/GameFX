using System.Collections.Generic;
using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "ArrayInt", menuName = "Variables/List of int")]
	public class ArrayInt : Array<int>
	{
		public void UpdateValues(List<int> values)
		{
		}

		public List<int> GetValue()
		{
			return null;
		}

		public void Reset()
		{
		}

		public void Replace(int toReplace, int replaceWith)
		{
		}

		public bool IsFullWithSameValue()
		{
			return false;
		}

		public bool HasSingleUniqueItem()
		{
			return false;
		}
	}
}
