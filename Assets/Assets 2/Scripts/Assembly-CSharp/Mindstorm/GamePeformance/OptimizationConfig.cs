using UnityEngine;

namespace Mindstorm.GamePeformance
{
	[CreateAssetMenu]
	public class OptimizationConfig : ScriptableObject
	{
		[NonReorderable]
		public OptimizationConfigsData[] URPPerformanceSettings;

		private PerformanceSettingsData _performanceSettings;

		public PerformanceSettingsData performanceSettings => null;

		public PerformanceSettingsData GetURPPerformanceSettings(PlatformType platform, DevicePerformaceType performaceType)
		{
			return null;
		}
	}
}
