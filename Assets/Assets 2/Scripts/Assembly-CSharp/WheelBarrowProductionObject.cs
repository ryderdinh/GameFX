using System.Collections.Generic;
using UnityEngine;

public class WheelBarrowProductionObject : BaseBoosterProductionObject
{
	[SerializeField]
	private Transform _wheelBarrowTransform;

	[SerializeField]
	private Transform _dishContainer;

	[SerializeField]
	private Transform[] _targetPoints;

	private WheelBarrowViewConfigs _configs;

	public void Initialize(WheelBarrowViewConfigs configs)
	{
	}

	public override void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}

	public float PlayBoosterProduction(List<Slot> slots)
	{
		return 0f;
	}

	private float MoveWheelBarrowBeforeShuffle(Dictionary<int, Dish> dishes)
	{
		return 0f;
	}

	private float MoveWheelBarrowAfterShuffle(Dictionary<int, Dish> dishes, List<int> randomSlots, List<Slot> slots)
	{
		return 0f;
	}
}
