using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "Int", menuName = "Variables/Int")]
	public class Int : ScriptableObject
	{
		[SerializeField]
		protected int Value;

		[SerializeField]
		protected int DefaultValue;

		[SerializeField]
		protected bool ResetToDefaultOnPlay;

		private void OnEnable()
		{
		}

		public virtual void SetValue(int value)
		{
		}

		public virtual void SetValue(Int value)
		{
		}

		public virtual int GetValue()
		{
			return 0;
		}

		public virtual void SetDefaultValue(int value)
		{
		}

		public virtual void SetDefaultValue(Int value)
		{
		}

		public virtual void ResetToDefaultValue()
		{
		}

		public static implicit operator int(Int integer)
		{
			return 0;
		}
	}
}
