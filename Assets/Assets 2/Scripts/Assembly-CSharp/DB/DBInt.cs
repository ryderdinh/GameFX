using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "DBInt", menuName = "Persistent Variables/Int")]
	public class DBInt : Int, IDBVariable
	{
		[SerializeField]
		protected string Key;

		public new void SetValue(int value)
		{
		}

		public new void SetValue(Int value)
		{
		}

		public new void ResetToDefaultValue()
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

		public virtual void ApplyChange(int amount)
		{
		}

		public virtual void ApplyChange(Int amount)
		{
		}

		public void Save()
		{
		}

		public virtual void Load()
		{
		}

		void IDBVariable.Update(object value)
		{
		}

		object IDBVariable.GetValue()
		{
			return null;
		}
	}
}
