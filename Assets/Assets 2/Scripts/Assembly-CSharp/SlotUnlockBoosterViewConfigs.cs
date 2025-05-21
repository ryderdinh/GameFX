using UnityEngine;

[CreateAssetMenu(fileName = "SlotUnlockBoosterViewConfigs", menuName = "BoosterProduction/SlotUnlockBoosterViewConfigs")]
public class SlotUnlockBoosterViewConfigs : BaseBoosterProductionViewConfig
{
	public Vector3 InitialPosition;

	public Vector3 InitialScale;

	public Vector3 StartPointHandle;

	public Vector3 TargetPointHandle;

	public float MovementTime;

	public float StayTime;

	public Vector3 TargetOffset;
}
