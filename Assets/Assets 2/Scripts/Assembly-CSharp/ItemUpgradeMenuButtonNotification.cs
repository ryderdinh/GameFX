using TMPro;
using UnityEngine;

public class ItemUpgradeMenuButtonNotification : MonoBehaviour
{
	[SerializeField]
	private GameObject _notification;

	[SerializeField]
	private TextMeshProUGUI _upgradesAvailablesCount;

	[SerializeField]
	private Animator _cardsAnimator;

	private static int ButtonDefaultKey;

	private static int ButtonInactiveKey;

	public bool CanUpdateNotificationState()
	{
		return false;
	}

	public void UpdateNotificationState()
	{
	}

	public void PlayInactiveAnimation()
	{
	}

	public void PlayDefaultAnimation()
	{
	}
}
