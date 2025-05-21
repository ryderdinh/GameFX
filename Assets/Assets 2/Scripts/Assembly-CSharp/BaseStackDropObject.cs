using UnityEngine;

public abstract class BaseStackDropObject : BoosterDropObject
{
	[SerializeField]
	private GameObject[] _stackObjects;

	protected int _StackObjectID;

	public override void DropBooster(BoosterDropData dropData)
	{
	}

	protected override void AnimateObjectOnClaim()
	{
	}

	protected override void SetAnimatorToOnBoardState(bool state)
	{
	}

	private void SetStackObject(int id)
	{
	}

	private void DisableStackObjects()
	{
	}
}
