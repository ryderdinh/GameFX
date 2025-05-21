using System;

namespace MS.Casual.AB
{
	[Serializable]
	public class FirebaseVariableBool : FirebaseVariable
	{
		public bool DefaultValue;

		public bool Value;

		public void SetValue(bool value)
		{
		}
	}
}
