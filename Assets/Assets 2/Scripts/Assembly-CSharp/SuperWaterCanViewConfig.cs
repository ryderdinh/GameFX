using UnityEngine;

[CreateAssetMenu(fileName = "SuperWaterCanViewConfigs", menuName = "Views/SuperWaterCanViewConfigs")]
public class SuperWaterCanViewConfig : BaseBoosterProductionViewConfig
{
	public float TargetXOffset;

	public float TargetYOffset;

	public float TargetZOffset;

	public Vector3 InitialPosition;

	public Vector3 InitialRotation;

	public Vector3 InitialScale;

	public Vector3 TargetRotation;

	public Vector3 TargetScale;

	[Header("Tween")]
	[Header("IN")]
	public Vector3 StartPointHandle;

	public Vector3 TargetPointHandle;

	public float MoveInDuration;

	public float ScaleInDuration;

	public float RotationInDuration;

	public float SlotToSlotMoveDuration;

	public float Slot2Offset;

	public float Slot3Offset;

	public float Slot4Offset;

	public float Slot5Offset;

	[Header("OUT")]
	public float WaterCanOutDelay;

	public float MoveOutDuration;

	public float ScaleOutDuration;

	public float RotationOutDuration;
}
