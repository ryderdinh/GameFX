using DG.Tweening;
using UnityEngine;

public class TrovelProductionObject : BaseBoosterProductionObject
{
	[SerializeField]
	private GameObject _trovelObj;

	private Sequence _trovelSequence;

	private TrovelViewConfig _configs;

	public void Initialize(TrovelViewConfig configs)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}

	private void TrovelSequence(Transform transform, Vector3 pos)
	{
	}

	private void ResetTransform(Transform transform)
	{
	}

	private void SetTrovelState(bool state)
	{
	}
}
