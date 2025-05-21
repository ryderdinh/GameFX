using DB;
using UnityEngine;
using UnityEngine.Serialization;

public class GameConfig : ScriptableObject
{
	[Header("Camera")]
	public float CameraSmoothDamp;

	[Header("Currency")]
	public double InitialCash;

	[Header("Board Empty Floater")]
	public string BoardEmptyFloaterText;

	[Header("Market")]
	public InAppItemData[] MarketItemsData;

	public DBBool _dBIsButterflyNewFlow;

	[FormerlySerializedAs("ToolsTutorialController")]
	[Header("Tutorial Configs")]
	public BoostersTutorialController boostersTutorialController;

	[Header("Cards Chest System")]
	public CardsChestSystem CardsChestSystem;

	[Header("DailyLoginController")]
	public DailyLoginController DailyLoginController;

	[Header("Item Upgrades System")]
	public ItemUpgradeSystem ItemUpgradeSystem;

	public LiveOpsSystem LiveOpsSystem;

	[Header("Market Free Coins Time")]
	public int MarketFreeCoinsToAdd;

	public int MarketFreeCoinsRewardTime;

	[Header("SpecialOffer")]
	public SpecialOfferItemData[] CoinsOfferItemData;

	[Tooltip("Time in seconds")]
	public double MinTimeToShowSpecialOfferOnLaunch;

	[Tooltip("Time in seconds")]
	public double MinTimeToShowSpecialOfferOnResume;

	public int MinCountGamePausedBeforeShowingOffer;

	public int MinLevelToShowOfferButtonOnMain;

	public DBInt DBGamePauseCountToShowSpecialOfferOnResume;

	[Header("StarterPack")]
	public SpecialOfferItemData StarterPackItemData;

	[Header("Cards Offers")]
	public SpecialOfferItemData[] CardsOffersItemData;

	[Header("SkipAds Offers")]
	public SpecialOfferItemData[] SkipAdsOffersItemData;

	[Header("LiveOps Offers")]
	public SpecialOfferItemData[] LiveOpsOffersItemData;

	public DBInt MetaWorldIndex;

	[Header("PassiveBoostersController")]
	public PassiveBoostersController PassiveBoostersController;

	public DishUpgradableObject DishUpgradableObject;

	[Header("PowerUpsSystem")]
	public PowerUpsSystem PowerUpsSystem;

	[Header("Progression System")]
	public ProgressionSystem ProgressionSystem;

	[Header("Progression System")]
	public MetaWorldConfig MetaWorldConfig;

	[Header("Cash Object")]
	public CashObject CashObject;

	[Header("All Items Object")]
	public AllItemsObject AllItemsObject;

	[Header("Refresh Trays")]
	public int[] RefreshTraysCost;

	[Header("SkipAdsObject")]
	public SkipAdsObject SkipAdsObject;

	[Header("Starter Pack")]
	public DBBool IsStarterPackPurchasedDB;

	public DBBool IsStarterPackAvailableDB;

	[Header("Streak System")]
	public StreakSystemObject StreakSystem;

	[Header("Tray")]
	public float TrayMovementSpeed;

	public LayerMask TrayLayerMask;

	public Vector3 InitialTrayPosition;

	public ValueRange TraysPositionRangeInX;

	public TraySpawnerObject TraySpawnerObject;

	public DishSpawnerObject DishSpawnerObject;

	public float TrayPositionInBoosterState;

	public float TrayPositionInGridBoosterState;

	public Vector3 TrayColliderSize;

	public float TrayColliderHorizontalDelta;

	public float TrayColliderVerticalDelta;

	public float TrayInitialScaleMultiplier;

	public float TrayMovingScaleMultiplier;

	[Header("TurboMode")]
	public TurboModeSystem TurboMode;

	public InAppItemData GetMarketItemsData(string sku)
	{
		return null;
	}

	public void SetButterflyNewFlow(bool value)
	{
	}

	public InAppItemData GetSpecialOffersData(string sku)
	{
		return null;
	}
}
