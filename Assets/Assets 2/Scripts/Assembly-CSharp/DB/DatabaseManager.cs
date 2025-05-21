using System;
using System.Collections.Generic;

namespace DB
{
	public class DatabaseManager
	{
		private static Dictionary<string, IDBVariable> _dbVariables;

		private static Database _database;

		private static Database Database => null;

		public static void LoadJsonData(Dictionary<string, object> jsonDict)
		{
		}

		public static Dictionary<string, object> GetJsonData()
		{
			return null;
		}

		public static bool HasKey(IDBVariable dBVariable, string key)
		{
			return false;
		}

		public static bool HasTimeKey(IDBVariable dBVariable, string key)
		{
			return false;
		}

		public static void SetInt(IDBVariable dBVariable, string key, int value)
		{
		}

		public static int GetInt(IDBVariable dBVariable, string key)
		{
			return 0;
		}

		public static void SetFloat(IDBVariable dBVariable, string key, float value)
		{
		}

		public static float GetFloat(IDBVariable dBVariable, string key)
		{
			return 0f;
		}

		public static void SetBool(IDBVariable dBVariable, string key, bool value)
		{
		}

		public static bool GetBool(IDBVariable dBVariable, string key)
		{
			return false;
		}

		public static void SetDouble(IDBVariable dBVariable, string key, double value)
		{
		}

		public static double GetDouble(IDBVariable dBVariable, string key)
		{
			return 0.0;
		}

		public static long GetLong(IDBVariable dBVariable, string key)
		{
			return 0L;
		}

		public static void SetLong(IDBVariable dBVariable, string key, long value)
		{
		}

		public static DateTime GetTime(IDBVariable dBVariable, string key, DateTime defaultValue)
		{
			return default(DateTime);
		}

		public static void SetTime(IDBVariable dBVariable, string key, DateTime value)
		{
		}

		public static void SetString(IDBVariable dBVariable, string key, string value)
		{
		}

		public static string GetString(IDBVariable dBVariable, string key)
		{
			return null;
		}

		private static void TrackVariable(IDBVariable dBVariable, string key)
		{
		}

		private static void SaveUnknownVariable(string key, object value)
		{
		}
	}
}
