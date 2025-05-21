using MSKit.ResourcePool;
using UnityEngine;

[CreateAssetMenu(fileName = "DishConfigs", menuName = "Game/Dish")]
public class DishConfig : ScriptableObject
{
	[Header("Dish")]
	public float GapInTwoDishesOnSelection;

	public float DishSize;

	public float DishPositionZ;

	public float DishDeltaFromTouchPoint;

	public float AppreciationSoundProbability;

	[Header("Complete Tweens")]
	public float CakeScaleDownDelayMultiplier;

	public float BudScaleUpMultipler;

	public float BudScaleDownMultipler;

	public float BudScaleUpAnimationTime;

	public float BudScaleDownAnimationTime;

	public float PotScaleUpMultipler;

	public float PotScaleUpAnimationTime;

	public float PotScaleDownAnimationTime;

	public float PotSequenceIntervalMultiplier;

	public float PotScaleDownOnCompleteAnimationTime;

	public float FlowerContainerScaleUpAnimationTime;

	public float FlowerContainerScaleUpMultipler;

	public float FlowerContainerRotationValueX;

	public float FlowerContainerRotationValueZ;

	public float FlowerContainerMoveUpValueZ;

	public float FlowerContainerIntervalAfterScaleUp;

	public float FlowerContainerRotationAnimationTime;

	public float FlowerPetalsRotationAnimationTime;

	public float FlowerCompleteParticleLifeTime;

	public ParticleSystem FlowerCompleteParticle;

	public Material FlowerCompleteMaterial;

	public Material FlowerCompletePetalsMaterial;

	public Material FlowerDefaultPetalsMaterial;

	public Shader FlowerCompleteShader;

	public float FlowerCompleteParticleYPosition;

	public float FlowerForceCompleteDelayInPetals;

	public float FlowerForceCompletePetalTime;

	[Header("Spawn Tweens")]
	public float CakeScaleStartDelayMin;

	public float CakeScaleStartDelayMax;

	public float PotSpawnScaleUpMultiplier;

	public float CakeScaleUpDelayMultiplier;

	public float PotSpawnScaleUpAnimationTime;

	public float BudSpawnScaleDelay;

	public float BudSpawnScaleUpAnimationTime;

	public float PotSpawnRotationAnimationTime;

	public float PotSpawnRotationDelay;

	public float PotSpawnRotationAngle;

	public float PotSpawnAngleRotationRangeMin;

	public float PotSpawnAngleRotationRangeMax;

	public float PotScaleToDefaultDelay;

	public float CakeSlicesSpawnDelay;

	public float PotEmptyDelay;

	[Header("Wrong Move Tweens")]
	public float CakeWobbleScaleAnimationTime;

	public float CakeWobbleRandomness;

	public int CakeWobbleVibrato;

	[Header("Water Can Slot Selection Tweens")]
	public float CakeScaleRandomness;

	[Header("Level Fail Tweens")]
	public float LevelFailCakeWobbleScaleAnimationTime;

	public float LevelFailCakeWobbleRandomness;

	public int LevelFailCakeWobbleVibrato;

	[Header("Vanish Dish Tween")]
	public float PotScaleDownOnVanishAnimationTime;

	[Header("Dual Dish Warning")]
	public Material DualDishMaterial;

	public Color DualDishInitialColor;

	public Color DualDishWarningStartColor;

	public Color DualDishWarningEndColor;

	public float DualDishWarningGlowTime;

	private Transform _flowerParent;

	private Pool<ParticleSystem> _completeParticles;

	private int _colorId;

	private void OnEnable()
	{
	}

	public ParticleSystem GetFlowerCompleteParticle()
	{
		return null;
	}

	public void ReturnFlowerCompleteParticle(ParticleSystem particle)
	{
	}

	public int GetFlowerColorId()
	{
		return 0;
	}

	public void SetFlowersParent(Transform parent)
	{
	}
}
