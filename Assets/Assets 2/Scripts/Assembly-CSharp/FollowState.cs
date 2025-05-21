using UnityEngine;

public class FollowState : CatState
{
	private float _idleTimer;

	private float _startTime;

	private float _journeyLength;

	private Transform _catTransform;

	private Vector3 _position;

	public FollowState(CatController catController, CatConfigs configs)
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
}
