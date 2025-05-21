using UnityEngine;
using UnityEngine.Rendering.Universal;

[CreateAssetMenu(fileName = "PerformanceSettingsData", menuName = "ScriptableObjects/Performance/Object")]
public class PerformanceSettingsData : ScriptableObject
{
	public int TargetFps;

	public UniversalRenderPipelineAsset UrpAsset;

	public bool AllowHaptics;

	public bool AllowPostProcessing;
}
