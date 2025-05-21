using System.Collections.Generic;
using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "ArrayBool", menuName = "Variables/List of bool")]
	public class ArrayBool : Array<bool>
	{
		public void UpdateValues(List<bool> values)
		{
		}

		public List<bool> GetValue()
		{
			return null;
		}

		public void Reset()
		{
		}

		public ArrayBoolObject GetSOToStruct()
		{
			return null;
		}
	}
}
