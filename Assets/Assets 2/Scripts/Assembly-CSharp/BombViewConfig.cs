using UnityEngine;

[CreateAssetMenu(fileName = "BombViewConfig", menuName = "Views/BombViewConfig")]
public class BombViewConfig : BaseBoosterProductionViewConfig
{
	public Vector3 InitialPosition;

	public Vector3 InitialRotation;

	public float BrushMoveInDuration;

	public float RotateInDuration;

	public float BrushMovementDurationMultiplier;

	public float BrushMovementDurationAdd;

	public float IntervalDuration;

	public float TargetScale;

	public float TargetXOffset;

	public float TargetYOffset;

	public float TargetZOffset;

	public Vector3 StartPointHandle;

	public Vector3 TargetPointHandle;

	public float AnimationSpeed;

	public float BombScale;

	public float BrushMoveOutDuration;
}
