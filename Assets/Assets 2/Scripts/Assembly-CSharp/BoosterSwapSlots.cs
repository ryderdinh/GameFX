using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class BoosterSwapSlots : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _gloves;

	[SerializeField]
	private Transform _glove1;

	[SerializeField]
	private Transform _glove2;

	[SerializeField]
	private SkinnedMeshRenderer _gloveMesh1;

	[SerializeField]
	private SkinnedMeshRenderer _gloveMesh2;

	private Sequence _gloveSequence;

	private Vector3 _initialRotation;

	private SwapSlotsViewConfig _configs;

	public void Initialize(SwapSlotsViewConfig configs)
	{
	}

	public override void PlayBoosterProduction(Transform transform, List<Slot> slots)
	{
	}

	private void ResetTransform()
	{
	}

	private void PlaySwapSlotSequence(Transform transform, List<Slot> slots)
	{
	}

	private void UpdateBlendShapeWeight()
	{
	}

	private void SetBlendShapeWeight(SkinnedMeshRenderer mesh, float weight)
	{
	}

	private void SetGlovesState(bool state)
	{
	}
}
