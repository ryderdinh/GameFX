using UnityEngine;

namespace BuildInfoUtility
{
	[CreateAssetMenu(fileName = "BuildRuntimeInfoSettings", menuName = "Build runtime info settings")]
	public class BuidRuntimeInfo : ScriptableObject
	{
		private static BuidRuntimeInfo _instance;

		public string Version;

		public string BuildId;

		public static BuidRuntimeInfo Instance => null;

		private static BuidRuntimeInfo LoadInfo()
		{
			return null;
		}
	}
}
