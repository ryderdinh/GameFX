using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "DBBool", menuName = "Persistent Variables/Bool")]
	public class DBBool : Bool, IDBVariable
	{
		[SerializeField]
		protected string Key;

		public new void SetValue(bool value)
		{
		}

		public new void SetValue(Bool value)
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
