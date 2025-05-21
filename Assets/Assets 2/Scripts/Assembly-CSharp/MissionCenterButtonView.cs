using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MissionCenterButtonView : MonoBehaviour
{
	[SerializeField]
	protected Button _missionCenterButton;

	[SerializeField]
	protected GameObject _notification;

	[SerializeField]
	protected TextMeshProUGUI _completedMissionsCountText;

	[SerializeField]
	protected Animator _clipboardAnimator;

	protected LiveOpsSystem _liveOpsSystem;

	protected int _completedMissionsCount;

	protected static int _clipBoardActivetKey;

	protected static int _clipBoardIdleKey;

	protected static int _clipBoardMovingInKey;

	public virtual void Initialize()
	{
	}

	private void RegisterButtons()
	{
	}

	private void RegisterEvents()
	{
	}

	public virtual void Show()
	{
	}

	public virtual void Hide()
	{
	}

	protected virtual void UpdateButtonState()
	{
	}

	protected bool CanActiveMissionCenterButtonState()
	{
		return false;
	}

	protected virtual void MissionCompleted()
	{
	}

	protected virtual void MissionCenterButtonClicked()
	{
	}

	private void PlayButtonImpact()
	{
	}
}
