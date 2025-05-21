using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "DBLong", menuName = "Persistent Variables/Long")]
	public class DBLong : Long, IDBVariable
	{
		[SerializeField]
		protected string Key;

		public new void SetValue(long value)
		{
		}

		public new void SetValue(Long value)
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

		public virtual void ApplyChange(long amount)
		{
		}

		public virtual void ApplyChange(Long amount)
		{
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
