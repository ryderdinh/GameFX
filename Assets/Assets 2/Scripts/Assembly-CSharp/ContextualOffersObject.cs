using System.Collections.Generic;
using Analytics;
using DB;
using MS.Casual.Login;
using UnityEngine;

[CreateAssetMenu(fileName = "ContextualOffersSystem", menuName = "ScriptableObjects/ContextualOffersSystem")]
public class ContextualOffersObject : ScriptableObject
{
	public StarterPackController StarterPackController;

	public CoinsOfferController CoinsOfferController;

	public CardsOffersController CardsOffersController;

	public SkipAdsOffersController SkipAdsOffersController;

	public LiveOpsOfferController LiveOpsOfferController;

	private const string LastOfferTimePrefix = "LastOfferTime";

	private const string GameLastPauseTimePrefix = "GameLastPauseTime";

	[SerializeField]
	private SkipAdsObject _skipAdsObject;

	[SerializeField]
	private int _CardsClickThreshold;

	[SerializeField]
	private int _CoinsClickThreshold;

	[SerializeField]
	private int _SkipAdsClickThreshold;

	[SerializeField]
	private int _starterPackClickThreshold;

	[SerializeField]
	private DBBool _dbSkipItOfferPurchasedBool;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	[SerializeField]
	private LiveOpsSystem _liveOpsSystem;

	[SerializeField]
	[Header("Probabilities")]
	private FullScreenOfferLaunchProbabilities[] _launchProbabilities;

	private SessionTimeController _sessionResumeTimeController;

	private SessionTimeController _sessionTimeController;

	private MonoBehaviour _coroutineRunner;

	private GameConfig _gameConfig;

	private MetaWorldConfig _worldConfig;

	private DBInt _dBPauseCount;

	private int _pauseCount;

	private int _cardsClickCount;

	private int _coinsClickCount;

	private int _skipAdsClickCount;

	private int _starterPackClickCount;

	private bool _skipItOfferPurchased;

	private bool _initialized;

	private List<BaseOfferController> _offerControllers;

	public void Initialize(MonoBehaviour mono)
	{
	}

	private void RegisterEvents()
	{
	}

	private void OnSkipItOfferPurchasedEvent()
	{
	}

	private void OnCollectableViewClickedEvent(CollectableViewTriggerModel model)
	{
	}

	private void ShowMarketOnCollectableViewClick(CollectableViewTriggerModel model)
	{
	}

	private void SkipItNotifyViewEvent(SkipAdsPurchaseViewModel model)
	{
	}

	private void OnApplicationResumeEvent()
	{
	}

	private void OnApplicationPauseEvent()
	{
	}

	private bool CanShowSpecialOfferOnLaunch()
	{
		return false;
	}

	public bool CanShowOfferOnMenu(Offers offer)
	{
		return false;
	}

	private bool IsUnlocked()
	{
		return false;
	}

	private void SetDBPauseCount()
	{
	}

	private Offers GetOfferToShowBasedOnProbability()
	{
		return default(Offers);
	}

	private void ShowOfferOnResume()
	{
	}

	private void InitializeContextualOffers()
	{
	}

	private void OnStarterPackAvailabilityChangedEvent(bool state)
	{
	}

	private void ShowSkipAdsFullScreenOffer(Offers offer)
	{
	}

	public void ShowOfferOnLaunch()
	{
	}

	public void ShowFullScreenOffer(Offers offer)
	{
	}

	public void ShowFullScreenOfferOnAd()
	{
	}

	public SpecialOfferModel GetCurrentOfferModel(Offers offer)
	{
		return default(SpecialOfferModel);
	}

	public bool GetOfferCooldownState(Offers offer)
	{
		return false;
	}
}
