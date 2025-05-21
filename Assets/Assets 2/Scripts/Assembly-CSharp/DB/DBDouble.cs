using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "DBDouble", menuName = "Persistent Variables/Double")]
	public class DBDouble : Double, IDBVariable
	{
		[SerializeField]
		protected string Key;

		public new void SetValue(double value)
		{
		}

		public new void SetValue(Double value)
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

		public virtual void ApplyChange(double amount)
		{
		}

		public virtual void ApplyChange(Double amount)
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
