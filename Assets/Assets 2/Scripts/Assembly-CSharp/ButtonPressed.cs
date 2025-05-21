using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

[RequireComponent(typeof(Button))]
public class ButtonPressed : MonoBehaviour, IPointerDownHandler, IEventSystemHandler, IPointerUpHandler
{
	[SerializeField]
	private bool _inactiveByDefault;

	[SerializeField]
	private Animator _buttonAnimator;

	[SerializeField]
	private Button _button;

	private static int ButtonPressedKey;

	private static int ButtonDefaultKey;

	private static int ButtonInactiveKey;

	private static int ButtonIdleKey;

	private static int ButtonPowerUpKey;

	public void SetButtonDefaultState(bool activeByDefault)
	{
	}

	private void OnEnable()
	{
	}

	public void PlayInactiveAnimation()
	{
	}

	public void PlayIdleAnimation()
	{
	}

	public void PlayPowerUpAnimation()
	{
	}

	private void Pressed()
	{
	}

	public void PlayDefaultAnimation()
	{
	}

	public void OnPointerDown(PointerEventData eventData)
	{
	}

	public void OnPointerUp(PointerEventData eventData)
	{
	}
}
