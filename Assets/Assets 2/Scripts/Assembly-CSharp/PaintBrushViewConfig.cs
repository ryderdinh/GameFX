using UnityEngine;

[CreateAssetMenu(fileName = "PaintBrushViewConfigs", menuName = "BoosterProduction/PaintBrushViewConfigs")]
public class PaintBrushViewConfig : BaseBoosterProductionViewConfig
{
	public float TargetXOffset;

	public float TargetYOffset;

	public float TargetZOffset;

	public Vector3 InitialPosition;

	public Vector3 InitialRotation;

	public Vector3 InitialScale;

	public Vector3 TargetScale;

	public float AnimationSpeed;

	public Color CakeColor;

	[Header("IN")]
	[Header("Tween")]
	public Vector3 StartPointHandle;

	public Vector3 TargetPointHandle;

	public float MoveInDuration;

	public float ScaleInDuration;

	public float RotationInDuration;

	[Header("OUT")]
	public float PaintBrushOutDelay;

	public float MoveOutDuration;

	public float ParticalStopDuration;

	public float RotationOutDuration;
}
