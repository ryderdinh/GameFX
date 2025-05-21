using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "Float", menuName = "Variables/Float")]
	public class Float : ScriptableObject
	{
		[SerializeField]
		protected float Value;

		[SerializeField]
		protected float DefaultValue;

		[SerializeField]
		protected bool ResetToDefaultOnPlay;

		private void OnEnable()
		{
		}

		public virtual void SetValue(float value)
		{
		}

		public virtual void SetValue(Float value)
		{
		}

		public virtual float GetValue()
		{
			return 0f;
		}

		public virtual void SetDefaultValue(float value)
		{
		}

		public virtual void SetDefaultValue(Float value)
		{
		}

		public virtual void ResetToDefaultValue()
		{
		}

		public static implicit operator float(Float value)
		{
			return 0f;
		}
	}
}
