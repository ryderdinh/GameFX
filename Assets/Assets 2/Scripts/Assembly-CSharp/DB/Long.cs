using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "Long", menuName = "Variables/Long")]
	public class Long : ScriptableObject
	{
		[SerializeField]
		protected long Value;

		[SerializeField]
		protected long DefaultValue;

		[SerializeField]
		protected bool ResetToDefaultOnPlay;

		private void OnEnable()
		{
		}

		public virtual void SetValue(long value)
		{
		}

		public virtual void SetValue(Long value)
		{
		}

		public virtual long GetValue()
		{
			return 0L;
		}

		public virtual void SetDefaultValue(long value)
		{
		}

		public virtual void SetDefaultValue(Long value)
		{
		}

		public virtual void ResetToDefaultValue()
		{
		}

		public static implicit operator long(Long value)
		{
			return 0L;
		}
	}
}
