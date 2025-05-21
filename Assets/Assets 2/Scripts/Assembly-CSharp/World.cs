using System.Collections.Generic;
using UnityEngine;

public class World : MonoBehaviour
{
	[SerializeField]
	private List<UpgradeableItem> _upgradeableItems;

	[SerializeField]
	private Transform _worldTransform;

	public Transform WorldTransform => null;

	public void Initialize()
	{
	}

	public void Show()
	{
	}

	public void SetWorldInProgress()
	{
	}

	public void PlayWorldAvailableTransition(float delay = 0f)
	{
	}
}
