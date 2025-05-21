using DG.Tweening;
using UnityEngine;

public class ChaseState : CatState
{
	private float _idleTimer;

	private Vector3 _position;

	private Transform _catTransform;

	private Sequence _chaseSequence;

	public ChaseState(CatController catController, CatConfigs configs)
		: base(null, null)
	{
	}

	public override void Enter()
	{
	}

	public override void Exit()
	{
	}

	public override void Update()
	{
	}

	private void Rotate()
	{
	}
}
