using UnityEngine;

public class CharacterController : MonoBehaviour
{
	[SerializeField]
	private GameObject _character;

	[SerializeField]
	private GameObject _characterObject;

	[SerializeField]
	private GameObject _camera;

	[SerializeField]
	private Animator _animator;

	[SerializeField]
	private CharacterAnimationConfig _configs;

	private CharacterAnimationController _animationController;

	public void Initialize()
	{
	}

	private void RegisterEvents()
	{
	}

	private void UnRegisterEvents()
	{
	}

	private void PlayAction(CharacterActionType actionType)
	{
	}

	private void PlayAnimation(CharacterAnimationType animationType)
	{
	}

	public void Hide()
	{
	}

	public void Show()
	{
	}

	private void SetCamState(bool status)
	{
	}

	private void SetState(bool status)
	{
	}

	private void SetCharacterState(bool status)
	{
	}
}
