using UnityEngine;

[CreateAssetMenu(fileName = "RespawnTraysObjectViewConfigs", menuName = "BoosterProduction/RespawnTraysObjectViewConfigs")]
public class RespawnTraysObjectViewConfigs : BaseBoosterProductionViewConfig
{
	public Vector3 InitialPosition;

	public Vector3 InitialRotation;

	public float TargetX;

	public Vector3[] TraysPositions;

	public Vector3 TraysRotation;

	public float BaseMovementTime;
}
