using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class SPPRewardView : MonoBehaviour
{
	[SerializeField]
	private SeasonalProgressPassSystem _seasonalProgressPassSystem;

	[Header("Claim Buttons")]
	[SerializeField]
	private Button _rewardCollectButton;

	[SerializeField]
	private Button _rewardCollectGreyButton;

	[SerializeField]
	[Header("Special Reward")]
	private CanvasGroup _specialRewardImageCanvas;

	[SerializeField]
	private Image _specialRewardImage;

	[SerializeField]
	private Image _yellowLineImage;

	[SerializeField]
	private TextMeshProUGUI _specialRewardAmountText;

	[SerializeField]
	private GameObject _specialRewardObj;

	[SerializeField]
	private GameObject _specialRewardAnimationObject;

	[SerializeField]
	[Header("Reward")]
	private Image _rewardImage;

	[SerializeField]
	private Image _whiteLineImage;

	[SerializeField]
	private TextMeshProUGUI _rewardAmountText;

	[SerializeField]
	private GameObject _rewardObj;

	[SerializeField]
	private GameObject _rewardAmountObject;

	[Header("Perk Reward")]
	[SerializeField]
	private Image _perkImage;

	[SerializeField]
	private Image _perkLine;

	[SerializeField]
	private Image _forSeason;

	[SerializeField]
	private GameObject _perkObject;

	[SerializeField]
	[Header("Reward Claimable State")]
	private GameObject _rewardClaimableState;

	[SerializeField]
	private Image _rewardClaimableStateGlow;

	[SerializeField]
	[Header("Particles")]
	private ParticleSystem _rewardParticles;

	[SerializeField]
	private ParticleSystem _collectedParticles;

	private SPPReward _sppReward;

	private Vector3 _defaultRewardButtonScale;

	private ISPPRewardView _isppRewardView;

	private bool _isPerkObject;

	public void Initialize(bool isAvailable, SPPReward sppReward, ISPPRewardView iSPPRewardView)
	{
	}

	private void RegisterEvents()
	{
	}

	public void Show(bool animatCompleteProgress, bool isReached, bool claimButtonState, bool showPerk)
	{
	}

	private void SetRewardState(bool isReached, bool claimButtonState)
	{
	}

	private void RewardClaimed()
	{
	}

	private void ShowClaimableState(bool animateIcon = true)
	{
	}

	public void ForceClaimedState(bool isReached)
	{
	}

	public void AnimateCompleteProgress(float delay, int missionID)
	{
	}

	public void ForceResetButtons(bool claimButtonState)
	{
	}

	public void UpdateButton(float delay = 0f)
	{
	}

	private void SetRewardButtonState(GameObject button, bool state)
	{
	}

	protected void PlayButtonImpact()
	{
	}

	private void SetClaimableState(bool state)
	{
	}
}
