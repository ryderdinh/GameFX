using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class RespawnTraysProductionObject : BaseBoosterProductionObject
{
	[SerializeField]
	private Transform _respawnTraysTransform;

	[SerializeField]
	private Transform _dishContainer;

	private RespawnTraysObjectViewConfigs _configs;

	private Sequence _respawnTraysSequence;

	public void Initialize(RespawnTraysObjectViewConfigs configs)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}

	public void PlayBoosterProduction(List<Tray> trays, Transform trayContainer)
	{
	}

	private void ResetTransform()
	{
	}

	private void ResetTrays(List<Tray> trays, Transform trayContainer)
	{
	}

	private void SetState(bool state)
	{
	}
}
