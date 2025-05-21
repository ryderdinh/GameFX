using System.Collections.Generic;
using UnityEngine;

public class MagicPotDropObject : BoosterDropObject
{
	[SerializeField]
	private GameObject _magicPot;

	[SerializeField]
	private Transform _flowerContainer;

	[SerializeField]
	private ItemSystem _itemSystem;

	private List<Flower> _cakes;

	private int _rotationMultiplier;

	private List<Collider> _boingColliders;

	public override void Initialize(Boosters booster, float disappearTime)
	{
	}

	public override void DropBooster(BoosterDropData dropData)
	{
	}

	private void SelfSort(bool force)
	{
	}

	private void ResetTransform()
	{
	}

	private void ResetCakes()
	{
	}
}
