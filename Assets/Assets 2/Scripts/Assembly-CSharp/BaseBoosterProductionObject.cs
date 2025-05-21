using System.Collections.Generic;
using UnityEngine;

public abstract class BaseBoosterProductionObject : MonoBehaviour
{
	public virtual void PlayBoosterProduction(Transform transform, Vector3 finalPosition)
	{
	}

	public virtual void PlayBoosterProduction(Transform transform, Vector3 finalPosition, List<bool> slots)
	{
	}

	public virtual void PlayBoosterProduction(Transform transform, List<Vector3> finalPosition)
	{
	}

	public virtual void PlayBoosterProduction(Transform transform, List<Slot> finalPosition)
	{
	}
}
