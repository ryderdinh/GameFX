using DG.Tweening;
using UnityEngine;

public class BoosterPaintBrush : BaseBoosterProductionObject
{
	[SerializeField]
	private SkinnedMeshRenderer _renderer;

	[SerializeField]
	private Material _smokeMaterial;

	[SerializeField]
	private Material _burstMaterial;

	[SerializeField]
	private Material _sparksMaterial;

	[SerializeField]
	private ParticleSystem _mistParticles;

	[SerializeField]
	private ParticleSystem _bubbleParticles;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private Transform _paintBrushTransform;

	private Sequence _paintBrushSequence;

	private PaintBrushViewConfig _configs;

	private static readonly int EmissionColor;

	public void Initialize(PaintBrushViewConfig configs)
	{
	}

	private void PlayPaintBrushSequence(Transform transform, Vector3 pos)
	{
	}

	private void ResetBlendShapes()
	{
	}

	private void SetParticleColor()
	{
	}

	private Gradient GetGradient()
	{
		return null;
	}

	private void SetEmissionColor()
	{
	}

	private void SetAnimatorState(bool state)
	{
	}

	private void ResetTransform(Transform transform)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}
}
