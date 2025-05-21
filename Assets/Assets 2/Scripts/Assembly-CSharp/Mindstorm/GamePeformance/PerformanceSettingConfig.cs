using UnityEngine;

namespace Mindstorm.GamePeformance
{
	public class PerformanceSettingConfig : ScriptableObject
	{
		public PlatformType PlatformType;

		public DevicePerformaceType PerformanceType;

		public bool FXAAEffect;

		public bool LightShadows;

		public int QualityLevel;
	}
}
