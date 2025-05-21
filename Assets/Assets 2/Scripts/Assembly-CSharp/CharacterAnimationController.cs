using DG.Tweening;
using UnityEngine;

public class CharacterAnimationController
{
	private readonly int _sadKey;

	private readonly int _clapKey;

	private readonly int _idleKey;

	private readonly int _kissKey;

	private readonly int _idle2Key;

	private readonly int _smileKey;

	private readonly int _angryKey;

	private readonly int _pointKey;

	private readonly int _smile2Key;

	private readonly int _idleArmKey;

	private readonly int _stunnedKey;

	private readonly int _lookDownLeft;

	private readonly int _lookDownRightKey;

	private readonly int _lookLeftToRightKey;

	private readonly int _sadMergeKey;

	private readonly int _idleStateKey;

	private readonly int _levelEndKey;

	private readonly int _levelEndStateKey;

	private Tween _levelEndLoop;

	private Animator _animator;

	private CharacterAnimationConfig _configs;

	public CharacterAnimationController(Animator animator, CharacterAnimationConfig configs)
	{
	}

	public void PlayAnimation(CharacterAnimationType animationType)
	{
	}

	public void PlayCharacterAction(CharacterActionType actionType)
	{
	}

	private void LevelEndStateUpdate()
	{
	}

	private void IdleStateUpdate()
	{
	}

	private void PlayWorriedAnimation()
	{
	}

	private void PlayMergeAnimation()
	{
	}

	private void PlayStreakAnimation()
	{
	}

	private void PlayComboAnimation()
	{
	}

	private void PlayGroupAnimaton(CharacterAction action)
	{
	}

	private void PlayIdle()
	{
	}

	private void PlayLevelEnd()
	{
	}

	private void PlayIdle2()
	{
	}

	private void PlayIdleArm()
	{
	}

	private void PlaySmile()
	{
	}

	private void PlayClap()
	{
	}

	private void PlayKiss()
	{
	}

	private void PlaySmile2()
	{
	}

	private void PlayStunned()
	{
	}

	private void PlaySad()
	{
	}

	private void PlayLeftToRight()
	{
	}

	private void PlayLookDownRight()
	{
	}

	private void PlayLookDownLeft()
	{
	}

	private void PlayAngry()
	{
	}

	private void PlayPoint()
	{
	}

	private void PlaySadMerge()
	{
	}

	private void SetIdleState(float value)
	{
	}

	private void SetLevelEndState(int value)
	{
	}

	private void SetLevelEndTrigger()
	{
	}
}
