using UnityEngine;

[CreateAssetMenu(fileName = "VerticalRocketViewConfigs", menuName = "Views/VerticalRocketViewConfigs")]
public class VerticalRocketViewConfig : BaseBoosterProductionViewConfig
{
	public float ScaleUpDuration;

	public float StartPoint;

	public float MoveUnits;

	public float ShearMoveDuration;

	public float ShearAnimationStartDelay;

	public float ShearAnimationStopDelay;
}
