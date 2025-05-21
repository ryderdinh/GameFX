using Analytics;
using UnityEngine;

[CreateAssetMenu(fileName = "UserJourneySystem", menuName = "ScriptableObjects/UserJourney/UserJourneySystem")]
public class UserJourneySystem : ScriptableObject
{
	[SerializeField]
	private BaseUserJourney _turnBasedUserJourney;

	[SerializeField]
	private BaseUserJourney _lifeTimeUserJourney;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	public string AppInstallDate => null;

	public double AdRevenue => 0.0;

	public double IAPRevenue => 0.0;

	public bool IsPayingUser => false;

	public double UserLTV => 0.0;

	public void Initialize()
	{
	}

	public void TurnCompleted()
	{
	}

	public void MatchMade(FlowerType flowerType)
	{
	}

	public void FlowerCardsCollected(FlowerType flowerType, FlowerCardSource cardSource, int amount)
	{
	}

	public void PowerUpEquipped(BoostersTypes boosterType)
	{
	}

	public void CoinsEarned(CoinSource coinSource, int coinsAmount)
	{
	}

	public void CoinsSink(CoinSink coinSink, int coinsAmount)
	{
	}

	public void PotPlaced()
	{
	}

	public void RefreshTraysUsed()
	{
	}

	public void ButterflyShown()
	{
	}

	public void ButterflyClicked()
	{
	}

	public void ButterflyUsed(BoostersTypes boosterType)
	{
	}

	public void ButterflyBoosterOffered(BoostersTypes boosterType)
	{
	}

	public void ButterflyRespin()
	{
	}

	public void LevelGiftBoosterOffered(BoostersTypes boosterType)
	{
	}

	public void LevelGiftUsed(BoostersTypes boosterType)
	{
	}

	public void LevelGiftRespin()
	{
	}

	public void RvWatched()
	{
	}

	public void InterWatched()
	{
	}

	public void SkipItUsed()
	{
	}

	public void ReviveUsed()
	{
	}

	public void ReviveOnCoinsUsed()
	{
	}

	public void AddAdRevenue(double amount)
	{
	}

	public void AddIAPRevenue(double amount)
	{
	}

	public UserJourneyData GetTurnBasedJourneyData()
	{
		return null;
	}

	public UserJourneyData GetLifeTimeJourneyData()
	{
		return null;
	}

	public int GetPotsPlacedInTurn()
	{
		return 0;
	}

	public int GetLifeTimeInterstitialsWatchedCount()
	{
		return 0;
	}

	public int GetLifeTimeRewardedAdsWatchedCount()
	{
		return 0;
	}
}
