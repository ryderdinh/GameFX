using UnityEngine;

[CreateAssetMenu(fileName = "TrovelViewConfig", menuName = "Views/TrovelViewConfig")]
public class TrovelViewConfig : BaseBoosterProductionViewConfig
{
	public float TrovelMoveDuration;

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

	public float TrovelScale;
}
