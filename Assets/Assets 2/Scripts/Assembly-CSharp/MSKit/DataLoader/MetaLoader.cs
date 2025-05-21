using System;
using System.Collections.Generic;

namespace MSKit.DataLoader
{
	public static class MetaLoader
	{
		private static readonly Dictionary<string, Action<string[]>> AllMetaTables;

		public static Dictionary<string, Action<string[]>> LevelMetaTable;

		public static Dictionary<string, Action<string[]>> VipLevelIntervalMetaTable;

		public static Dictionary<string, Action<string[]>> PieceSortMetaTable;

		public static Dictionary<string, Action<string[]>> ExperienceMetaTable;

		public static void LoadData()
		{
		}

		private static bool LoadDataUsingCSV(string data)
		{
			return false;
		}

		private static string LoadResourcesMetaFileData()
		{
			return null;
		}

		private static void BindMetaTables()
		{
		}

		private static void LoadLevelData(string[] elements)
		{
		}

		private static void LoadVipLevelInterval(string[] elements)
		{
		}

		private static void LoadPieceSortData(string[] elements)
		{
		}

		private static void ExperienceData(string[] elements)
		{
		}
	}
}
