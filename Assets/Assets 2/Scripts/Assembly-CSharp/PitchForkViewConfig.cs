using UnityEngine;

[CreateAssetMenu(fileName = "PitchForkViewConfig", menuName = "Views/PitchForkViewConfigs")]
public class PitchForkViewConfig : BaseBoosterProductionViewConfig
{
	public float ShearMoveDuration;

	public Vector3 InitialPosition;

	public float IntervalDuration;

	public float TargetXOffset;

	public float TargetYOffset;

	public float TargetZOffset;

	public float RotationXOffset;

	public float RotationDuration;

	public float RotationResetDuration;

	public Vector3 StartPointHandle;

	public Vector3 TargetPointHandle;

	public float PitchForkScale;
}
