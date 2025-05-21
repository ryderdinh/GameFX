using UnityEngine;

[CreateAssetMenu(fileName = "LargeFertilizerViewConfigs", menuName = "BoosterProduction/LargeFertilizerViewConfigs")]
public class LargeFertilizerViewConfig : BaseBoosterProductionViewConfig
{
	public Vector3 InitialPosition;

	public Vector3 InitialRotation;

	public Vector3 InitialScale;

	public float TargetPositionX;

	public Vector3 TargetRotation;

	public Vector3 TargetScale;

	public float WaitForRotation;

	public float WaitForFertilizer;

	public float RotateDuration;

	public float MoveDuration;

	public float MoveOutDuration;
}
