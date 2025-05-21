using System;
using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SwitchToggle : MonoBehaviour
{
	[SerializeField]
	private RectTransform _uiHandleRectTransform;

	[SerializeField]
	private Toggle _toggle;

	[SerializeField]
	private Image _bgImage;

	[SerializeField]
	private Image _handleImage;

	[SerializeField]
	private TextMeshProUGUI _onText;

	[SerializeField]
	private TextMeshProUGUI _offText;

	[SerializeField]
	private TextMeshProUGUI _label;

	private Action _actionCallBack;

	private Sequence _toggleSequence;

	private Vector2 _handlePosition;

	private bool _state;

	public void Initialize(Action Callback, bool status)
	{
	}

	public void Show(bool status)
	{
	}

	private void Toggle(bool on)
	{
	}

	private void OnSwitch(bool on)
	{
	}

	private void ScaleStatusText(Transform transform)
	{
	}
}
