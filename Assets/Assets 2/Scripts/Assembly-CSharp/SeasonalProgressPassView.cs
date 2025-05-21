using System.Collections.Generic;
using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class SeasonalProgressPassView : BaseUIViewController<SeasonalProgressPassViewRefs>, IMatchesProgressMissionSPP
{
	private List<MatchesProgressMissionSPPView> _matchesProgressMissionSPPView;

	private List<MatchesProgressMissionSPP> _matchesProgressMissionSPP;

	private int _numberOfMissions;

	private Vector3 _defaultPositionsContentContainer;

	private Vector3 _defaultPositionsBottomHUD;

	private Vector3 _defaultPositionsTopHUD;

	private Sequence _viewAnimationSequence;

	private SPPConfig _sppConfig;

	protected static int _activatedKey;

	private void SetTimeData(int timeRemaining)
	{
	}

	private void OnEventTimerUpdate(EventTimeData eventTimeData)
	{
	}

	public override void Initialize()
	{
	}

	private void ForceSnap(bool top)
	{
	}

	private void ScrollView(float delay = 0f)
	{
	}

	public override void Show(object model = null)
	{
	}

	public override void Hide()
	{
	}

	public override void InitializeButtons()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public void CloseButtonClicked()
	{
	}

	public void UpdateZone()
	{
	}

	private void BuyButtonClicked()
	{
	}

	private void MoveToClaimableReward(bool scroll)
	{
	}

	private void AnimateBgPattern(float duration)
	{
	}

	bool IMatchesProgressMissionSPP.ClaimReward(int id, RewardType reward, int rewardAmount, int rewardSubIndex, SPPRewardType sppRewardType)
	{
		return false;
	}

	private void AnimateInView()
	{
	}

	private void AnimateOutView()
	{
	}

	private void SetDefaultPositions()
	{
	}

	private void BloomPassPurchased()
	{
	}

	private void MoveVertically(Transform transform, Vector3 pos, float delta, float duration, Ease ease, float delay = 0f)
	{
	}

	private void ForceMoveVertically(Transform transform, Vector3 pos, float delta)
	{
	}

	private void SetActivationText()
	{
	}

	int IMatchesProgressMissionSPP.UnclaimedMissionIndex()
	{
		return 0;
	}
}
