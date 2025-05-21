using System;

namespace MS.Casual.AB
{
	[Serializable]
	public class FirebaseVariableInt : FirebaseVariable
	{
		public int DefaultValue;

		public int Value;

		public void SetValue(int value)
		{
		}
	}
}
