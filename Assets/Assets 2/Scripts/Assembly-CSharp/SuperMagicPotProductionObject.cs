using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class SuperMagicPotProductionObject : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _magicPot;

	[SerializeField]
	private Transform _dishTransform;

	[SerializeField]
	private Transform _midBud;

	[SerializeField]
	private Transform _flowerContainer;

	[SerializeField]
	private MeshFilter _midMesh;

	[SerializeField]
	private ParticleSystem _completeParticles;

	[SerializeField]
	private ParticleSystem _trailParticles;

	private Sequence _magicPotSequence;

	private Sequence _cakeCompleteSequence;

	private SuperMagicPotProductionObjectConfigs _configs;

	private DishConfig _dishConfig;

	private float delayMultiplier;

	private List<Flower> _cakes;

	private int _rotationMultiplier;

	private float _dishScale;

	private float _dishScaleOnComplete;

	public void Initialize(SuperMagicPotProductionObjectConfigs configs)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}

	public float PlayBoosterProduction(List<Slot> cleaningSlots, List<Flower> allRemovedCakes, Collider[] boingColliders, int cakeID, int cakesToRemoveCount)
	{
		return 0f;
	}

	public void HighlightTiles(List<Slot> cleaningSlots)
	{
	}

	public void UnhighlightTiles(List<Slot> cleaningSlots)
	{
	}

	private void CakeScaleUpSequence()
	{
	}

	private void RotateSpecialDish(Transform specialdish, float time)
	{
	}

	private void PluckAnimation(List<Flower> cakes, int startIndex, int endIndex)
	{
	}

	private void AddCake(Flower cake, bool sort = true)
	{
	}

	public void SelfSort(bool force)
	{
	}

	private int ForceCompleteDish(int cakeID, Collider[] boingColliders, int removeAll)
	{
		return 0;
	}

	private float SpawnCakes(int cakeID, Collider[] boingColliders)
	{
		return 0f;
	}

	private void AfterForceCompleteDish(int removeall)
	{
	}

	private void ResetCakes(int removeall)
	{
	}

	private void ResetTransform()
	{
	}

	private Sequence CakeCompleteSequence(int removeall)
	{
		return null;
	}

	public void UpdateMidMesh()
	{
	}

	private void SpawnFlowerCompleteParticle()
	{
	}

	private void GiveScore(int cakeID)
	{
	}

	private void ApplyForce(Flower cake)
	{
	}

	private void RemoveForce(List<Flower> cakes, int startIndex, int endIndex)
	{
	}

	private void SetFlowerCompleteColor(int cakeId)
	{
	}
}
