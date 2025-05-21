using UnityEngine;

[CreateAssetMenu(fileName = "WaterCanViewConfigs", menuName = "BoosterProduction/WaterCanViewConfigs")]
public class WaterCanViewConfig : BaseBoosterProductionViewConfig
{
	public Vector3 InitialScale;

	public Vector3 TargetScale;

	[Header("Move In From Left")]
	public Vector3 TargetOffsetLeft;

	public Vector3 InitialPositionLeft;

	public Vector3 InitialRotationLeft;

	public Vector3 TargetRotationLeft;

	[Header("Move In From Right")]
	public Vector3 TargetOffsetRight;

	public Vector3 InitialPosition;

	public Vector3 InitialRotation;

	public Vector3 TargetRotation;

	[Header("IN")]
	[Header("Tween")]
	public Vector3 StartPointHandle;

	public Vector3 TargetPointHandle;

	public Vector3 TargetPointHandleLeft;

	public float MoveInDuration;

	public float ScaleInDuration;

	public float RotationInDuration;

	[Header("OUT")]
	public float WaterCanOutDelay;

	public float MoveOutDuration;

	public float ScaleOutDuration;

	public float RotationOutDuration;
}
