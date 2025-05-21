using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "Double", menuName = "Variables/Double")]
	public class Double : ScriptableObject
	{
		[SerializeField]
		protected double Value;

		[SerializeField]
		protected double DefaultValue;

		[SerializeField]
		protected bool ResetToDefaultOnPlay;

		private void OnEnable()
		{
		}

		public virtual void SetValue(double value)
		{
		}

		public virtual void SetValue(Double value)
		{
		}

		public virtual double GetValue()
		{
			return 0.0;
		}

		public virtual void SetDefaultValue(double value)
		{
		}

		public virtual void SetDefaultValue(Double value)
		{
		}

		public virtual void ResetToDefaultValue()
		{
		}

		public static implicit operator double(Double value)
		{
			return 0.0;
		}
	}
}
