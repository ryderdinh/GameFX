using System.Collections.Generic;
using DB;
using DG.Tweening;
using UnityEngine;

public class ItemObject : MonoBehaviour
{
	[SerializeField]
	private ItemSystem _itemSystem;

	[SerializeField]
	private Transform _unlockedFlowerParent;

	[SerializeField]
	private MeshFilter _unlockedFlowerMeshFilter;

	[SerializeField]
	private Dish _dish;

	[SerializeField]
	private ParticleSystem[] _burstParticles;

	[SerializeField]
	private ParticleSystem[] _auraLeavesParticles;

	[SerializeField]
	private ParticleSystem _flowerRotationParticle;

	[SerializeField]
	private Transform _midBudUnlockedFlowerObject;

	[SerializeField]
	private Camera _camera;

	[SerializeField]
	private Material _levelEndPetalsMaterial;

	[SerializeField]
	private ArrayInt _arrayInt;

	private DishConfig _dishConfig;

	private FlowerType _flowerType;

	private Sequence _flowerPotSequence;

	private List<FlowerUIObject> _unlockedCakeObjects;

	public void Initialize()
	{
	}

	public void Initialize(FlowerType flowerType, RenderTexture renderTexture)
	{
	}

	private void RegisterEvents()
	{
	}

	private void SetCameraState(bool state)
	{
	}

	private void ForceUpdateTier(int flowerId)
	{
	}

	private void SetDishState(bool state)
	{
	}

	public void FlowerCompleteOnLevelEnd()
	{
	}

	public void UpdateFlowerTier(int cakeID)
	{
	}

	public void PlayBurstParticles()
	{
	}

	public void PlayFinalParticles()
	{
	}

	public void PlayRotationParticles(int cakeId)
	{
	}

	private void UpdateParticlesColor()
	{
	}

	private void UpdateAuraParticlesColor(int cakeId)
	{
	}

	public void UpdateDishMesh(Mesh mesh)
	{
	}

	private void DishScaleUpSequence(Transform dishTransform)
	{
	}

	public void UpdateProgressFlowerRenderer(FlowerType flowerType)
	{
	}

	public void SpawnFirstLevelPetals()
	{
	}

	public void SpawnFlowers()
	{
	}

	public void RotateDishSequence()
	{
	}

	private void RotateDishSequence(Transform dishTransform, Transform midBud)
	{
	}

	public void WrongMoveSequence()
	{
	}
}
