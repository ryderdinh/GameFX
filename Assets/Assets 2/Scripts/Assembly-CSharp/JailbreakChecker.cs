public static class JailbreakChecker
{
	public static bool CheckSandbox()
	{
		return false;
	}

	public static bool CheckSchemes()
	{
		return false;
	}

	public static bool CheckFiles()
	{
		return false;
	}

	public static bool CheckFilesInUnity()
	{
		return false;
	}

	public static bool CheckSymlinks()
	{
		return false;
	}

	public static bool CheckDyld()
	{
		return false;
	}

	public static string[] GetDyldPaths()
	{
		return null;
	}

	public static bool IsJailbroken()
	{
		return false;
	}
}
