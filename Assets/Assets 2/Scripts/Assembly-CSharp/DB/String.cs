using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "String", menuName = "Variables/String")]
	public class String : ScriptableObject
	{
		[SerializeField]
		protected string Value;

		[SerializeField]
		protected string DefaultValue;

		[SerializeField]
		protected bool ResetToDefaultOnPlay;

		[SerializeField]
		protected bool ResetOnClear;

		private void OnEnable()
		{
		}

		public virtual void SetValue(string value)
		{
		}

		public virtual void SetValue(String value)
		{
		}

		public virtual string GetValue()
		{
			return null;
		}

		public virtual void SetDefaultValue(string value)
		{
		}

		public virtual void SetDefaultValue(String value)
		{
		}

		public virtual void ResetToDefaultValue()
		{
		}

		public static implicit operator string(String value)
		{
			return null;
		}
	}
}
