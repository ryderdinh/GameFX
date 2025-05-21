using System.Collections.Generic;
using DG.Tweening;
using MSKit.ResourcePool;
using UnityEngine;

public class FlowerSpreadView : MonoBehaviour
{
	[SerializeField]
	private FlowerParticle _flower;

	[SerializeField]
	private Transform _flowerContainer;

	[SerializeField]
	private FlowerSpreadConfigs _configs;

	[SerializeField]
	private ParticleSystem _impactParticles;

	private Camera _uiCamera;

	private Pool<FlowerParticle> _flowerPool;

	private List<Sprite> _flowerSprites;

	private Vector3 _startPosition;

	private Vector3 _targetPosition;

	private Sequence _targetScaleSequence;

	public void Initialize(Vector3 targetPosition)
	{
	}

	private void UpdateSpriteList()
	{
	}

	public void PlayFlowerParticles(Transform targetTransform)
	{
	}
}
