using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "DBFloat", menuName = "Persistent Variables/Float")]
	public class DBFloat : Float, IDBVariable
	{
		[SerializeField]
		protected string Key;

		public new void SetValue(float value)
		{
		}

		public new void SetValue(Float value)
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

		public virtual void ApplyChange(float amount)
		{
		}

		public virtual void ApplyChange(Float amount)
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
