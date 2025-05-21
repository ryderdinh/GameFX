using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ActionButtonView : MonoBehaviour
{
	[SerializeField]
	private Button _button;

	[SerializeField]
	private Transform _defaultContainer;

	[SerializeField]
	private Transform _activeContainer;

	[SerializeField]
	private Transform _defaultIcon;

	[SerializeField]
	private Transform _activeIcon;

	[SerializeField]
	private Image _activeImageBg;

	[SerializeField]
	private TextMeshProUGUI _labelText;

	[SerializeField]
	private TextMeshProUGUI _notificationCount;

	[SerializeField]
	private GameObject _notification;

	public ActionButton ActionButton;

	private int _index;

	private Vector3 _defautPosition;

	private Sequence _actionButtonSequence;

	public Transform GetDefaultContainer()
	{
		return null;
	}

	public void Initialize(int index)
	{
	}

	public void RegisterEvents(UnityAction action)
	{
	}

	public void UnRegisterEvents()
	{
	}

	public void ResetButton()
	{
	}

	public Sequence SetButtonActive()
	{
		return null;
	}

	private void ForceReset()
	{
	}

	private void Move(bool moveIn)
	{
	}

	private void ForceMove(bool moveIn)
	{
	}

	public void UpdateNotificationState(int count)
	{
	}
}
