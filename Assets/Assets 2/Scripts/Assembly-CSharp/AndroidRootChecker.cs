using UnityEngine;

public static class AndroidRootChecker
{
	private static AndroidJavaObject _rootUtils;

	private static AndroidJavaObject _currentActivity;

	private static bool _initialized;

	private static readonly string[] RootAppsPackages;

	private static readonly string[] FilesPaths;

	private static readonly string[] SuPaths;

	private static readonly string[] ReadOnlyPaths;

	private static readonly string[] SuCommands;

	private const string AndroidClassName = "com.unitymedved.rootchecker.RootUtils";

	private const string UnityClassName = "com.unity3d.player.UnityPlayer";

	private const string UnityClassField = "currentActivity";

	private static void Initialize()
	{
	}

	public static bool CheckPackages()
	{
		return false;
	}

	public static bool CheckFiles()
	{
		return false;
	}

	public static bool CheckBinaries()
	{
		return false;
	}

	public static bool CheckDangerousProps()
	{
		return false;
	}

	public static bool CheckReadWritePaths()
	{
		return false;
	}

	public static bool CheckTestKeys()
	{
		return false;
	}

	public static bool CheckCommandsExists()
	{
		return false;
	}

	public static bool IsRooted()
	{
		return false;
	}
}
