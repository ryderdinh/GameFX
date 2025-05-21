using UnityEngine;

public abstract class BaseHapticsController : MonoBehaviour
{
	protected float _HapticIntensityStartValue;

	protected float _HapticIntensityMaxValue;

	protected float _HapticIntesitySpeedMultiplier;

	protected float _HapticIntensityCurrentValue;

	protected float _HapticSharpnessStartValue;

	protected float _HapticSharpnessMaxValue;

	protected float _HapticSharpnessSpeedMultiplier;

	protected float _HapticSharpnessCurrentValue;

	private const float _hapticDuration = 100f;

	private bool _isHapticActive;

	public void Initialize(float intensityStart, float intensityMax, float intensitySpeedMultiplier, float sharpnessStart, float sharpnessMax, float sharpnessSpeedMultiplier)
	{
	}

	protected void GiveHapticImpact()
	{
	}

	public void StopHaptic()
	{
	}

	public void ChangeImpactValue(float intensity, float sharpness)
	{
	}

	public void ChangeMaxSharpness(float value)
	{
	}

	public void ChangeMaxIntensity(float value)
	{
	}

	public void PlayTransientImpact(float intensity, float sharpness)
	{
	}

	public void PlayCustomImpact(float startIntensity, float endIntensity, float startSharpness, float endSharpness, float duration)
	{
	}

	private void StartHaptic()
	{
	}

	private void UpdateHaptic()
	{
	}

	private void ResetHapticState()
	{
	}

	protected abstract void CalculateHapticIntensity();

	protected abstract void CalculateHapticSharpness();
}
