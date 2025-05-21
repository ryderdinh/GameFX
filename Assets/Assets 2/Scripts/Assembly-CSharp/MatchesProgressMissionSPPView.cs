using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MatchesProgressMissionSPPView : MonoBehaviour, ISPPRewardView
{
	[SerializeField]
	private Image _fillBar;

	[SerializeField]
	private TextMeshProUGUI _matchesTargetText;

	[SerializeField]
	private GameObject _reachedObj;

	[SerializeField]
	private GameObject _reachedObjCheckMark;

	[SerializeField]
	private GameObject _milestoneObj;

	[SerializeField]
	private GameObject _tick;

	[SerializeField]
	private SPPRewardView _sppRewardView;

	[SerializeField]
	private SPPRewardView _sppPremiumRewardView;

	[SerializeField]
	private Vector3 _startingValue;

	[SerializeField]
	private float _constant;

	[SerializeField]
	private SeasonalProgressPassSystem _seasonalProgressPassSystem;

	private MatchesProgressMissionSPP _mission;

	private IMatchesProgressMissionSPP _iMatchesProgressMissionSPP;

	private int _previousTarget;

	private Vector3 _reachedObjCheckMarkScale;

	private GameObject _matchesProgress;

	private TextMeshProUGUI _matchesProgressText;

	private bool _isSPPRewardAvailable;

	private bool _isSPPPremiumRewardAvailable;

	public int Target => 0;

	public int PreviousTarget => 0;

	public void Initialize(MatchesProgressMissionSPP mission, int previousTarget, IMatchesProgressMissionSPP iMatchesProgressMissionSPP, GameObject matchesProgress, TextMeshProUGUI matchesProgressText)
	{
	}

	public void Show(int currentProgress, int previousProgress, bool animate, float delay, int unclaimedIndex, bool isAnimating, bool showPerk)
	{
	}

	private void ClaimedState()
	{
	}

	private bool ForceSetBar(int previousProgress, ref int startingPoint, int targetDelta)
	{
		return false;
	}

	private void AnimateBar(bool setBar, float amount, int startingPoint, int currentProgress)
	{
	}

	public void UpdateButton(int currentProgress, float delay = 0f)
	{
	}

	public bool IsRewardClaimable(int currentProgress)
	{
		return false;
	}

	private void AnimateCompleteProgress(float delay, bool isBarSet, int previousProgress)
	{
	}

	private void UpdateProgressText(float x)
	{
	}

	private void ReachedState(bool state)
	{
	}

	private bool IsBarInProgress(int currentProgress)
	{
		return false;
	}

	private void SetBar(Vector3 position)
	{
	}

	bool ISPPRewardView.ClaimReward(RewardType reward, int rewardAmount, int rewardSubIndex, SPPRewardType sppRewardType)
	{
		return false;
	}

	int ISPPRewardView.UnclaimedMissionIndex()
	{
		return 0;
	}
}
