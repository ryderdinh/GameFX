using UnityEngine;

[CreateAssetMenu(fileName = "CakeConfigs", menuName = "Game/Cake")]
public class CakeConfig : ScriptableObject
{
	[Header("CAKE")]
	public float CakeOffsetInZ;

	[Header("Move and Rotate Tweens")]
	public float MoveAnimationTime;

	public float RotationAnimationTime;

	public float RotationAnimationTimeDelta;

	[Header("Complete Tweens")]
	public float CakeCompleteScaleUpMultiplier;

	public float CakeCompleteScaleDownMultiplier;

	public float CakeCompleteScaleAnimationTime;

	[Header("Spawn Tweens")]
	public float CakeSpawnScaleUpAnimationTime;

	private int _petalTextureId;

	private int _petalEmissionId;

	private void OnEnable()
	{
	}

	public int GetPetalTextureId()
	{
		return 0;
	}

	public int GetPetalEmissionTextureId()
	{
		return 0;
	}
}
