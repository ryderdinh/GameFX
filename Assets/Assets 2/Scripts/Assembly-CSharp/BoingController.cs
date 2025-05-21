using System.Collections.Generic;
using UnityEngine;

public class BoingController : MonoBehaviour, IBoing
{
	[SerializeField]
	private BoingCollisionData _boingCollisionData;

	private List<Collider> _boingColliders;

	public void Initialize()
	{
	}

	public void StartGame()
	{
	}

	private void GenerateBoingCollidersList()
	{
	}

	List<Collider> IBoing.GetBoingColliders()
	{
		return null;
	}

	public Transform GetBoingMovementCollisionObject()
	{
		return null;
	}

	public void FailGame()
	{
	}

	private BoingCollidersDataModel GetBoingColliders()
	{
		return default(BoingCollidersDataModel);
	}
}
