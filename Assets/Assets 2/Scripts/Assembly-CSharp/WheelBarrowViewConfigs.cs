using UnityEngine;

[CreateAssetMenu(fileName = "WheelBarrowViewConfigs", menuName = "BoosterProduction/WheelBarrowViewConfigs")]
public class WheelBarrowViewConfigs : BaseBoosterProductionViewConfig
{
	public Vector3 InitialPositionBeforeShuffle;

	public Vector3 InitialRotationBeforeShuffle;

	public float TargetXBeforeShuffle;

	public float BaseMovementTimeBeforeShuffle;

	public float DelayInDishesBeforeShuffle;

	public float DishMovementTimeBeforeShuffle;

	public Vector3 InitialPositionAfterShuffle;

	public Vector3 InitialRotationAfterShuffle;

	public float TargetXAfterShuffle;

	public float BaseMovementTimeAfterShuffle;

	public float DelayInDishesAfterShuffle;

	public float DishMovementTimeAfterShuffle;
}
