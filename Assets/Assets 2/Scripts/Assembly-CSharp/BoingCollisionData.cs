using System;
using UnityEngine;

[Serializable]
public struct BoingCollisionData
{
	public GameObject BoingMovementCollisionObject;

	public Collider[] BoingMovementColliders;

	public Collider[] BoingWindColliders;
}
