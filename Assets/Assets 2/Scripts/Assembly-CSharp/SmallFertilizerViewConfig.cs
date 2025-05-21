using UnityEngine;

[CreateAssetMenu(fileName = "SmallFertilizerViewConfigs", menuName = "BoosterProduction/SmallFertilizerViewConfigs")]
public class SmallFertilizerViewConfig : BaseBoosterProductionViewConfig
{
	public Vector3 InitialPosition;

	public Vector3 InitialRotation;

	public Vector3 TargetOffset;

	public Vector3 TargetRotation;

	public Vector3 StartPointHandle;

	public Vector3 EndPointHandle;

	public float WaitForRotation;

	public float WaitForFertilizer;

	public float RotateDuration;

	public float MoveDuration;

	public float MoveOutDuration;
}
