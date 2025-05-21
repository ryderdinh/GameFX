using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class MissionCenterNotificationButtonView : MissionCenterButtonView
{
	[SerializeField]
	private RectTransform _taskCompletedContainerRect;

	[SerializeField]
	private GameObject _taskCompletedContainerObj;

	[SerializeField]
	private Image _tickBgImage;

	[SerializeField]
	private Image _tickImage;

	[SerializeField]
	private Vector3 _defaultPosition;

	[SerializeField]
	private Vector3 _initialPosition;

	[SerializeField]
	private Vector3 _targetPosition;

	private Vector2 _sizeOfTaskCompleted;

	private Sequence _taskCompletedSequence;

	private bool _isAlreadyActive;

	public override void Initialize()
	{
	}

	public override void Show()
	{
	}

	protected override void MissionCompleted()
	{
	}

	protected override void UpdateButtonState()
	{
	}

	private void ResetTaskCompleted()
	{
	}

	protected override void MissionCenterButtonClicked()
	{
	}
}
