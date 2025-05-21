using DB;
using UnityEngine;

public abstract class BaseUserJourney : ScriptableObject
{
	[SerializeField]
	protected DBString _journeyDataDB;

	[SerializeField]
	protected DBInt _highScore;

	[SerializeField]
	protected DBInt _MetaInProgress;

	[SerializeField]
	private string[] _variablesToPort;

	protected JourneyData _DataToStore;

	[Header("Coins")]
	[SerializeField]
	protected CoinAnalytics _CoinAnalytics;

	[Header("Levels")]
	[SerializeField]
	protected LevelSystem _LevelSystem;

	public int PotsPlacedCount => 0;

	public int IntersWatchedCount => 0;

	public int RewardedAdWatchedCount => 0;

	public string AppInstallDate => null;

	public double AdRevenue => 0.0;

	public double IAPRevenue => 0.0;

	public bool IsPayingUser => false;

	public virtual void Initialize()
	{
	}

	public abstract void TurnCompleted();

	public abstract UserJourneyData GetUserJourneyData();

	public virtual void MatchMade(FlowerType flowerType)
	{
	}

	public virtual void FlowerCardsCollected(FlowerType flowerType, FlowerCardSource cardSource, int cardsCollected)
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

	public void PowerUpEquipped(BoostersTypes boosterType)
	{
	}

	public void ButterflyUsed(BoostersTypes boosterType)
	{
	}

	public void LevelGiftUsed(BoostersTypes boosterType)
	{
	}

	public void ButterflyBoosterOffered(BoostersTypes boosterType)
	{
	}

	public void LevelGiftBoosterOffered(BoostersTypes boosterType)
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

	public void ButterflyRespin()
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

	public void SkipItsUsed()
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

	protected void IncrementValue(ref int item)
	{
	}

	protected void IncrementValue(ref double item, double amount)
	{
	}

	private void LoadData()
	{
	}

	private void SaveData()
	{
	}

	private void PortVariables()
	{
	}
}
