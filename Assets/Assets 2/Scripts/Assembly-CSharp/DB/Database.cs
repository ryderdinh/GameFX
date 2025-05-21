using System;
using UnityEngine;

namespace DB
{
	public class Database : ScriptableObject
	{
		public virtual string Encrypt(string text)
		{
			return null;
		}

		public virtual void Save()
		{
		}

		public virtual bool HasTimeKey(string key)
		{
			return false;
		}

		public virtual bool HasKey(string key)
		{
			return false;
		}

		public virtual void Clear()
		{
		}

		public virtual void RemoveKey(string key)
		{
		}

		public virtual void SetInt(string key, int value)
		{
		}

		public virtual int GetInt(string key, int defaultValue = 0)
		{
			return 0;
		}

		public virtual void SetFloat(string key, float value)
		{
		}

		public virtual float GetFloat(string key, float defaultValue = 0f)
		{
			return 0f;
		}

		public virtual void SetDouble(string key, double value)
		{
		}

		public virtual void SetLong(string key, long value)
		{
		}

		public virtual double GetDouble(string key, double defaultValue = 0.0)
		{
			return 0.0;
		}

		public virtual long GetLong(string key, long defaultValue = 0L)
		{
			return 0L;
		}

		public virtual void SetString(string key, string value)
		{
		}

		public virtual void SetTime(string key, DateTime value)
		{
		}

		public virtual DateTime GetTime(string key, DateTime defaultValue)
		{
			return default(DateTime);
		}

		public virtual string GetString(string key, string defaultValue = "")
		{
			return null;
		}

		public virtual void SetBool(string key, bool value)
		{
		}

		public virtual bool GetBool(string key, bool defaultValue = false)
		{
			return false;
		}
	}
}
