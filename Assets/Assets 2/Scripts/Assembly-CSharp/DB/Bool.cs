using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "Bool", menuName = "Variables/Bool")]
	public class Bool : ScriptableObject
	{
		[SerializeField]
		protected bool Value;

		[SerializeField]
		protected bool DefaultValue;

		[SerializeField]
		protected bool ResetToDefaultOnPlay;

		private void OnEnable()
		{
		}

		public virtual void SetValue(bool value)
		{
		}

		public virtual void SetValue(Bool value)
		{
		}

		public virtual bool GetValue()
		{
			return false;
		}

		public virtual void SetDefaultValue(bool value)
		{
		}

		public virtual void SetDefaultValue(Bool value)
		{
		}

		public virtual void ResetToDefaultValue()
		{
		}

		public static implicit operator bool(Bool integer)
		{
			return false;
		}
	}
}
