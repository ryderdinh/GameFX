using UnityEngine;

[CreateAssetMenu(fileName = "SPPConfig", menuName = "ScriptableObjects/SeasonalProgressPassSystem/SPPConfig")]
public class SPPConfig : ScriptableObject
{
	[Header("Delay")]
	public float InitialDelayBeforeProgressAnimation;

	public float ConstantDelayBetweenProgressAnimations;

	[Header("Scroll")]
	public float MaximumScrollValue;

	public float StartContentPosY;

	public float MiddleMissionWidth;

	public float StartContentPosYDelta;
}
