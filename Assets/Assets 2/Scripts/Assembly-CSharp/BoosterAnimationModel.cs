using System;
using UnityEngine;

public struct BoosterAnimationModel
{
	public Vector3 StartPosition;

	public Vector3 EndPosition;

	public int Count;

	public Action CallBack;

	public float MovementDelay;

	public BoosterAnimationModel(Vector3 startPosition, Vector3 endPosition, int count, Action callBack, float movementDelay)
	{
		StartPosition = default(Vector3);
		EndPosition = default(Vector3);
		Count = 0;
		CallBack = null;
		MovementDelay = 0f;
	}
}
