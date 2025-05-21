using System.Collections.Generic;
using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class MissionCenterView : BaseUIViewController<MissionCenterViewRefs>, ISingleMissionObjectView
{
	private List<DailyMissionObjectView> _dailyMissionObjectViews;

	private List<SeasonalMissionObjectView> _seasonalMissionObjectViews;

	private List<DailyMissionController> _dailyMissionController;

	private Vector3 _defaultPositionsContainer;

	private float _initialMissionRowAnimationDelay;

	private float _scrollTime;

	private const float _missionsToScroll = 4f;

	private bool _isOpenFromMenu;

	private void OnEventTimerUpdate(EventTimeData eventTimeData)
	{
	}

	public override void Initialize()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public override void Show(object model = null)
	{
	}

	private void SetTimeData(EventTimeData eventTimeData)
	{
	}

	private void SetupSeasonalMissions()
	{
	}

	private void SortSeasonalMissions(List<SingleMissionObjectView> singleMissionObjectViews)
	{
	}

	private void SetupDailyMissions()
	{
	}

	private void ClearDailyMissions()
	{
	}

	public override void Hide()
	{
	}

	private void SetupView()
	{
	}

	public override void InitializeButtons()
	{
	}

	private void CloseButtonClicked()
	{
	}

	public override void InitializeTexts()
	{
	}

	private void ForceSnapToTop()
	{
	}

	private void ScrollView(bool top, float delay = 0f)
	{
	}

	private void ForceSnap(bool top)
	{
	}

	private void AnimateView(bool state)
	{
	}

	private void MoveVertically(Transform transform, Vector3 pos, float delta, float duration, Ease ease, float delay = 0f)
	{
	}

	private void ForceMoveVertically(Transform transform, Vector3 pos, float delta)
	{
	}

	void ISingleMissionObjectView.ClaimDailyMission(RewardType missionReward, int rewardAmount, Vector3 startPosition)
	{
	}
}
