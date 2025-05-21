using System;

namespace MSKit.Database
{
	public class DatabaseTimeState
	{
		public readonly string _key;

		public DatabaseTimeState(string key)
		{
		}

		public DateTime GetState()
		{
			return default(DateTime);
		}

		public void SetState(DateTime value)
		{
		}

		public void RemoveState()
		{
		}

		public bool HasKey()
		{
			return false;
		}
	}
}
