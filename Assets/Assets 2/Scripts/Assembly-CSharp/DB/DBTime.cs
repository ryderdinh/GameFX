using System;
using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "DBTime", menuName = "Persistent Variables/Time")]
	public class DBTime : Time, IDBVariable
	{
		[SerializeField]
		protected string Key;

		public new void SetValue(DateTime value)
		{
		}

		public new void SetValue(Time value)
		{
		}

		public void SetKey(string key)
		{
		}

		public void Refresh()
		{
		}

		private void OnEnable()
		{
		}

		public string GetKey()
		{
			return null;
		}

		public void Save()
		{
		}

		public virtual void Load()
		{
		}

		object IDBVariable.GetValue()
		{
			return null;
		}

		void IDBVariable.Update(object value)
		{
		}
	}
}
