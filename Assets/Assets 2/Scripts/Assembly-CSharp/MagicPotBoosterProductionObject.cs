using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class MagicPotBoosterProductionObject : BaseBoosterProductionObject
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
	private ParticleSystem _leavesParticles;

	[SerializeField]
	private MeshFilter _midMesh;

	[SerializeField]
	private ParticleSystem _flowerRotationParticle;

	[SerializeField]
	private ParticleSystem _completeParticles;

	[SerializeField]
	private ParticleSystem _trailParticles;

	private Sequence _magicPotSequence;

	private Sequence _cakeCompleteSequence;

	private MagicPotBoosterProductionViewConfig _configs;

	private DishConfig _dishConfig;

	private float delayMultiplier;

	private List<Flower> _cakes;

	private int _rotationMultiplier;

	private float _dishScale;

	private float _dishScaleOnComplete;

	public void Initialize(MagicPotBoosterProductionViewConfig configs)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}

	public void PlayBoosterProduction(List<Slot> cleaningSlots, List<Flower> allRemovedCakes, Collider[] boingColliders, int cakeID, int cakesToRemoveCount)
	{
	}

	private void CakeScaleUpSequence()
	{
	}

	private void RotateSpecialDish(Transform specialdish, float time)
	{
	}

	private void PluckAnimation(List<Flower> cakes)
	{
	}

	private void AddCake(Flower cake, bool sort = true)
	{
	}

	public void SelfSort(bool force)
	{
	}

	private int ForceCompleteDish(int cakeID, Collider[] boingColliders)
	{
		return 0;
	}

	private void SpawnCakes(int cakeID, Collider[] boingColliders)
	{
	}

	private void AfterForceCompleteDish()
	{
	}

	private void ResetCakes()
	{
	}

	private void ResetTransform()
	{
	}

	private Sequence CakeCompleteSequence(float height = 0f)
	{
		return null;
	}

	public void UpdateMidMesh()
	{
	}

	private void SpawnFlowerCompleteParticle()
	{
	}

	private void ApplyForce(Flower cake)
	{
	}

	private void RemoveForce(List<Flower> cakes)
	{
	}

	private void SetFlowerCompleteColor(int cakeId)
	{
	}

	public void HighlightTiles(List<Slot> cleaningSlots)
	{
	}

	public void UnhighlightTiles(List<Slot> cleaningSlots)
	{
	}

	private void SpawnFlowerCompleteParticles()
	{
	}

	private void GiveScore(int cakeID)
	{
	}
}
