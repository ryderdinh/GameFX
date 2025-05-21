using System;
using System.Collections.Generic;
using DB;
using UnityEngine;

[Serializable]
public class SeasonalProgressController
{
	[SerializeField]
	private DBInt _dbCurrentUnclaimedMissionIndex;

	[SerializeField]
	private DBBool _dbCurrentRewardClaimState;

	private int _currentUnclaimedMissionIndex;

	private bool _currentRewardClaimState;

	private bool _isPremium;

	private List<MatchesProgressMissionSPP> _matchesProgressMissionSPP;

	public int CurrentUnclaimedMissionIndex => 0;

	public void Initialize(List<MatchesProgressMissionSPP> matchesProgressMissionSPPs, bool isPremium)
	{
	}

	public bool CanClaim(int id)
	{
		return false;
	}

	public bool IsRewardClaimed(int id)
	{
		return false;
	}

	public void MarkClaimed(int id)
	{
	}

	public void MoveToNextReward(int lastRewardId)
	{
	}

	public void Reset()
	{
	}

	public bool IsUnclaimedRewardAvailable(int progress)
	{
		return false;
	}

	public int GetUnlclaimedRewardsCount(int progress)
	{
		return 0;
	}

	public void GoToNextAvailableReward()
	{
	}

	private void InitializeValues()
	{
	}
}
