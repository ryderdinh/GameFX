using System;

namespace MS.Casual.AB
{
	[Serializable]
	public class FirebaseVariableString : FirebaseVariable
	{
		public string DefaultValue;

		public string Value;

		public void SetValue(string value)
		{
		}
	}
}
