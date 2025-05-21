using System;
using System.Collections.Generic;
using UnityEngine;

public static class Utility
{
	private static bool isIphoneX;

	private static bool isOldIphone;

	private static readonly DateTime epoch;

	private static List<string> currencyStringsShortNotations;

	public static bool IsIphoneX => false;

	public static bool IsOldIphone => false;

	public static void Initialize()
	{
	}

	public static void AddDictionaryElementInDictionary<T, S>(this Dictionary<T, S> source, Dictionary<T, S> collection)
	{
	}

	public static string DictionaryToString(Dictionary<string, string> data)
	{
		return null;
	}

	public static Dictionary<string, string> StringToDictionary(string data)
	{
		return null;
	}

	public static float DeviceAspectRatio()
	{
		return 0f;
	}

	public static bool IsInternetAvailable()
	{
		return false;
	}

	public static string Encrypt(this string text, int key = 910867680)
	{
		return null;
	}

	public static double ToDouble(string val)
	{
		return 0.0;
	}

	public static float ToFloat(string val)
	{
		return 0f;
	}

	public static int ToInt(string val)
	{
		return 0;
	}

	public static Vector3 ToVector3(string sVector)
	{
		return default(Vector3);
	}

	public static string TrimBundleVersionString(this string str)
	{
		return null;
	}

	public static TValue GetValue<TKey, TValue>(this Dictionary<TKey, TValue> data, TKey key)
	{
		return default(TValue);
	}

	public static void RecreateDirectory(string path)
	{
	}

	private static bool IsiPhoneX()
	{
		return false;
	}

	private static bool IsOlderIphone()
	{
		return false;
	}

	public static int GetRandomValueExceptArray(int min, int max, int[] numbersToExclude)
	{
		return 0;
	}

	public static List<Vector3> CalculateTrajectoryPoints(Vector3 spawnPoint, Vector3 spawnControlPoint, Vector3 endPoint, Vector3 endControlPoint)
	{
		return null;
	}

	public static int ToEpoch(this DateTime dateTime)
	{
		return 0;
	}

	public static DateTime FromUnixTime(long unixTime)
	{
		return default(DateTime);
	}

	public static string GetRemainingTime(this DateTime date, DateTime endTime)
	{
		return null;
	}

	public static string ConvertToTimeFormat(int value)
	{
		return null;
	}

	public static string ConvertToHoursFormat(int value)
	{
		return null;
	}

	public static string ConvertToHoursAndMinutesFormat(int value)
	{
		return null;
	}

	public static string ConvertToMinutesAndSecondsFormat(int value)
	{
		return null;
	}

	public static string ConvertToDaysFormat(int value)
	{
		return null;
	}

	public static string ConvertToSecondsFormat(int value)
	{
		return null;
	}

	public static string GetTimeInDaysFormat(int value)
	{
		return null;
	}

	public static void UpdateCloseButtonScale(this Transform obj, float startScale, float endScale)
	{
	}

	public static void SetPivot(this RectTransform rectTransform, Vector2 pivot)
	{
	}

	public static string GetTimeInDaysWrappedFormat(int value)
	{
		return null;
	}
}
