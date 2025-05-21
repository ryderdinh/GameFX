using System.Collections.Generic;
using UnityEngine;

public interface IBoing
{
	List<Collider> GetBoingColliders();

	Transform GetBoingMovementCollisionObject();
}
