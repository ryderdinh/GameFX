using System;
using BoingKit;
using DG.Tweening;
using UnityEngine;

[Serializable]
public class Flower : MonoBehaviour
{
	public BoingBones BoingBones;

	public ParticleSystem _trailParticles;

	public SkinnedMeshRenderer SkinnedMeshRenderer;

	public int FlowerId;

	public FlowerType FlowerType;

	private Sequence _cakeSequence;

	private CakeConfig _cakeConfig;

	private bool _isNewlyAddedCake;

	private DishConfig _dishConfig;

	private ItemSystem _itemSystem;

	private MaterialPropertyBlock _normalMaterialPropertyBlock;

	private int _textureId;

	private int _emissionMapTextureId;

	public int Id => 0;

	public void Initialize(Transform parent, Collider[] boingColliders, float initialScale = 1f)
	{
	}

	public void AddBoingColliders(Collider[] boingColliders)
	{
	}

	public void ChangeDish(Transform parent, bool isNewlyAddedCake)
	{
	}

	public void Reset()
	{
	}

	public void ScaleDownCake(float delay)
	{
	}

	public void PlayTrailParticles()
	{
	}

	public void SetTrayParticleColor()
	{
	}

	public void SetFree()
	{
	}

	public void RotateAndMoveCake(int angle, bool force)
	{
	}

	public float ScaleDownOnCompletion(float delay = 0f)
	{
		return 0f;
	}

	public void ScaleUpCakeSequence(float delay = 0f)
	{
	}

	public void ScaleUpPetalSequenceOnTierUpdate()
	{
	}

	public void ScaleDownPetalSequenceOnTierUpdate()
	{
	}

	private void InitializeMaterial()
	{
	}

	private void SetToNormalMaterial()
	{
	}

	public void SetToGlowMaterial()
	{
	}

	private void SetCakeState(bool state)
	{
	}
}
