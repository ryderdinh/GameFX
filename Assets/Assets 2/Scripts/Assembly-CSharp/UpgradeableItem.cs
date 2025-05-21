using UnityEngine;

public class UpgradeableItem : MonoBehaviour
{
	private readonly int _unlockKey;

	private readonly int _allOnKey;

	[SerializeField]
	private Transform _itemTransform;

	[SerializeField]
	private Animator _animator;

	public virtual void Initialize()
	{
	}

	public void SetItemInProgress(float delay = 0f)
	{
	}

	protected void PlayButtonImpact()
	{
	}

	public void PlayItemAvailableTransition(float delay = 0f)
	{
	}

	private void PlayAllOnAnimation()
	{
	}

	private void PlayUnlockAnimation()
	{
	}

	public void SetState(bool state)
	{
	}
}
