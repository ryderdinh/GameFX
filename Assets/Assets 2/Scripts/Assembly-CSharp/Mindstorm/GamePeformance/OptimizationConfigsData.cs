using System;

namespace Mindstorm.GamePeformance
{
	[Serializable]
	public struct OptimizationConfigsData
	{
		public PlatformType Platform;

		public DevicePerformaceType PerformaceType;

		public PerformanceSettingsData PerformanceSettingsData;
	}
}
