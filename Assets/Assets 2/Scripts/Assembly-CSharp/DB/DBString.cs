using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "DBString", menuName = "Persistent Variables/String")]
	public class DBString : String, IDBVariable
	{
		[SerializeField]
		protected string Key;

		public new void SetValue(string value)
		{
		}

		public new void SetValue(String value)
		{
		}

		public void SetKey(string key)
		{
		}

		public virtual void Refresh()
		{
		}

		private void OnEnable()
		{
		}

		public string GetKey()
		{
			return null;
		}

		public virtual void ApplyChange(string text)
		{
		}

		public virtual void ApplyChange(String text)
		{
		}

		public new void SetDefaultValue(string value)
		{
		}

		public new void SetDefaultValue(String value)
		{
		}

		public override void ResetToDefaultValue()
		{
		}

		public virtual void Save()
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
