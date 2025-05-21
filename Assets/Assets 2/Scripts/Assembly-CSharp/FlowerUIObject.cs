using DG.Tweening;
using UnityEngine;

public class FlowerUIObject : MonoBehaviour
{
	public ParticleSystem _trailParticles;

	private Sequence _cakeSequence;

	private CakeConfig _cakeConfig;

	private int _cakeID;

	public SkinnedMeshRenderer SkinnedMeshRenderer;

	private ItemSystem _itemSystem;

	private DishConfig _dishConfig;

	private MaterialPropertyBlock _normalMaterialPropertyBlock;

	private int _textureId;

	private int _emissionMapTextureId;

	public void Initialize(int id, Vector3 rotation, Vector3 scale, bool levelFailFlower = false)
	{
	}

	public void UpdateLayer(int layer)
	{
	}

	public void PlayTrailParticles()
	{
	}

	public void SetTrayParticleColor()
	{
	}

	public void ScaleUpPetalSequenceOnTierUpdate()
	{
	}

	public void Reset()
	{
	}

	private void SetCakeState(bool state)
	{
	}

	public void RotateAndMoveCake(int angle, bool force)
	{
	}

	public void ScaleDownPetalSequenceOnTierUpdate()
	{
	}

	private void InitializeMaterial()
	{
	}

	public void SetToNormalMaterial()
	{
	}

	public void SetToGlowMaterial()
	{
	}
}
