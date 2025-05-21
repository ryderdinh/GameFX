using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class MissionObjectView : MonoBehaviour
{
	[SerializeField]
	protected Button _RewardCollectButton;

	[SerializeField]
	protected Image _MissionProgressImage;

	[SerializeField]
	protected TextMeshProUGUI _MissionProgressText;

	[SerializeField]
	protected TextMeshProUGUI _MissionDescriptionText;

	[SerializeField]
	protected TextMeshProUGUI _MissionRewardText;

	protected MissionType _missionType;

	protected abstract void CollectingReward();

	public abstract void Show();
}
