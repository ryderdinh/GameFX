using System;
using UnityEngine;

namespace DB
{
	[CreateAssetMenu(fileName = "Time", menuName = "Variables/Time")]
	public class Time : ScriptableObject
	{
		[SerializeField]
		protected SerializableDateTime Value;

		[SerializeField]
		protected SerializableDateTime DefaultValue;

		[SerializeField]
		protected bool ResetToDefaultOnPlay;

		private void OnEnable()
		{
		}

		public virtual void SetValue(DateTime value)
		{
		}

		public virtual void SetValue(Time value)
		{
		}

		public virtual void SetDefaultValue(DateTime value)
		{
		}

		public virtual void SetDefaultValue(Time value)
		{
		}

		public virtual void ResetToDefaultValue()
		{
		}

		public virtual DateTime GetValue()
		{
			return default(DateTime);
		}

		public static implicit operator SerializableDateTime(Time value)
		{
			return null;
		}
	}
}
