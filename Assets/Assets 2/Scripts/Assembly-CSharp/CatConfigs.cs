using UnityEngine;

public class CatConfigs : ScriptableObject
{
	[Header("Idle State")]
	public float IdleDuration;

	[Header("Attack State")]
	public float AttackDuration;

	[Header("Hit State")]
	public float HitDuration;

	[Header("Pet State")]
	public float PetDuration;

	[Header("Move State")]
	public float MoveDuration;

	public float MoveTime;

	public float MoveOffset;

	public float MoveRotationSpeed;

	[Header("Chase State")]
	public float ChaseDuration;

	public float ChaseRadius;

	public float ChaseRotationDuration;

	public float SpinSpeed;

	public float SpinOffset;

	[Header("Follow State")]
	public float FollowSpeed;

	public float TargetOffset;

	public float StateChangeOffset;
}
