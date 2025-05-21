using System;
using UnityEngine;

namespace DB
{
	[Serializable]
	public class SerializableDateTime : IComparable<SerializableDateTime>
	{
		[SerializeField]
		private long m_ticks;

		private bool initialized;

		private DateTime m_dateTime;

		public DateTime DateTime => default(DateTime);

		public SerializableDateTime(DateTime dateTime)
		{
		}

		public int CompareTo(SerializableDateTime other)
		{
			return 0;
		}
	}
}
