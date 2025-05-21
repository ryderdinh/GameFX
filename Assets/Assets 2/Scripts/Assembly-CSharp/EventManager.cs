using Casual.MatchOrb.Notification;
using MSKit.Currency;
using MSKit.Events;
using MSKit.UIView;
using UnityEngine;

public static class EventManager
{
	public delegate void NotificationSignature00(LocalNotificationSO localNotification, NotificationText notificationText);

	public delegate void NotificationSignature01(NotificationId notificationId, int remainingTime);

	public static Observable OnApplicationPause;

	public static Observable OnApplicationResume;

	public static Observable<Currency> OnUpdateCurrency;

	public static Observable OnLoadHomeView;

	public static Observable OnPreLoadGame;

	public static Observable OnLoadGame;

	public static Observable OnUnLoadGame;

	public static Observable OnStartGame;

	public static Observable OnFailGame;

	public static Observable OnGameEnd;

	public static Observable OnShopComplete;

	public static Observable OnCompleteGame;

	public static Observable OnSkipGame;

	public static Observable OnRestartGame;

	public static Observable OnGameplaySceneLoaded;

	public static Observable OnStopGame;

	public static Observable<bool> OnSetDishState;

	public static Observable<int> OnGameMenuPanelChanged;

	public static Observable<MarketViewData> OnGoToShopPanel;

	public static Observable OnGoToFlowerMenuPanel;

	public static Observable OnGoToMainMenuPanel;

	public static Observable<ActionButton> OnGetActiveMenu;

	public static Observable<ActionButtonViewData> OnGetHomeButtonRect;

	public static Observable<ActionButtonViewData> OnGetFlowerUpgradesButtonRect;

	public static Observable<GameLevelDataModel> OnAddGameLevelData;

	public static Observable<GameDataContainer, GameLevelDataModel> OnGetGameLevelData;

	public static Observable<LevelDataModel> OnAddLevelData;

	public static Observable<int, LevelDataModel> OnGetLevelData;

	public static Observable OnLevelFailRetry;

	public static Observable<int, LevelDataModel> OnGetGameToAssign;

	public static Observable<LevelDataModel> OnGetCurrentGameData;

	public static Observable<bool> OnIsVipGamePlayed;

	public static Observable<int> OnSetVipGameInteval;

	public static Observable<int> OnGetTotalVipLevels;

	public static Observable<int> OnGetTotalLevels;

	public static Observable<int> OnGetCurrentLevel;

	public static Observable<GameType, int> OnGetGameLevel;

	public static Observable OnUpdateLevelProgress;

	public static Observable OnGameLoadingComplete;

	public static Observable<Vector3> OnGetCoinAnimPosition;

	public static Observable<UIViewDataModel> OnShowView;

	public static Observable OnHideView;

	public static Observable<Views> OnHideViewWithId;

	public static Observable OnHideAllViews;

	public static Observable<int> OnGetOpenViewsCount;

	public static Observable<UICameraData> OnGetUICamera;

	public static Observable<bool> OnSetMetaCameraState;

	public static Observable<Views, bool> IsViewActive;

	public static Observable<Views, bool> IsViewOnTop;

	public static Observable<Views, bool> IsOnlyViewActive;

	public static Observable<bool> SetGraphicRaycasterState;

	public static Observable<UICanvasGroupData> OnGetUICanvasGroup;

	public static Observable<FloaterText> OnShowFloater;

	public static Observable<CustomFloaterText> OnShowCustomFloater;

	public static Observable OnPlayConfetti;

	public static Observable<AdEventData, bool> OnShowAd;

	public static Observable<bool> IsRvLoaded;

	public static Observable OnInterstitialClosedOffer;

	public static Observable<InterstitialClosedEventData> OnInterstitialClosed;

	public static Observable OnResetAdTimers;

	public static Observable<AdShownEventData> OnAdShown;

	public static Observable<AdEventData> OnHideAd;

	public static Observable<bool> OnBannerAdStateUpdated;

	public static Observable OnBannerShownAfterInter;

	public static Observable OnLoadBannerAd;

	public static Observable<bool> OnResetInGameInterTime;

	public static Observable OnAdNotAvailable;

	public static Observable<AdPlacementEventData> OnRewardedVideoViewOpen;

	public static Observable<AdPlacementEventData> OnInterstitialShown;

	public static Observable<AdPlacementEventData> OnShowRewardedAdUI;

	public static Observable<AdPlacementEventData> OnNoAdsOfferAvailed;

	public static Observable<RVShownEventData> OnRewardedVideoAdShown;

	public static Observable OnAppOpenAdClosed;

	public static Observable<bool> OnToggleAmazonTestAds;

	public static Observable OnEnableAdjustTestAds;

	public static Observable OnFetchFirebaseData;

	public static Observable OnHelpShiftViewOpened;

	public static Observable<InAppIdDataEvent, InAppRewardDataEvent> GetInAppRewardData;

	public static Observable OnRemoveAdsPurchased;

	public static Observable OnValidateRemoveAdsPurchased;

	public static Observable<GetAppreciationBannerEventData> OnGetAppreciationBannerView;

	public static Observable<GetStreakBannerEventData> OnGetStreakBannerView;

	public static Observable<CollectablesData> OnUpdateScoreView;

	public static Observable<CollectablesData> OnUpdateCoinView;

	public static Observable<CollectablesData> OnShowComboView;

	public static Observable OnShowNewHighScoreBanner;

	public static Observable OnSetCanShowHighScoreBanner;

	public static Observable<BoingCollidersDataModel> GetBoingColliders;

	public static Observable<Vector3> OnShowButterflyTutorial;

	public static Observable OnButterflyTutorialCompleted;

	public static Observable OnPowerUpSpinnerClosed;

	public static Observable OnButterflySpawnedEvent;

	public static Observable OnButterflyExitEvent;

	public static Observable<float> OnScoreUpdatedForButterflyEvent;

	public static Observable<bool> OnGetButterflyUnlockedEvent;

	public static Observable OnUpdateButterflySpawnTargetScoreEvent;

	public static Observable<bool> OnIsButterflyTutorialActive;

	public static Observable<int> OnButterflyDropDespawnTimeUpdateEvent;

	public static Observable<BoosterDropConfig> OnUpdateBoosterDropConfigEvent;

	public static Observable<BoostersTutorialDataModel> OnShowBoostersTutorial;

	public static Observable OnBoostersTutorialCompleted;

	public static Observable<BoostersTutorialDataModel> OnShowDropBoosterTutorial;

	public static Observable OnHideBoosterInfoHeader;

	public static Observable<BoosterActivationDataModel> OnBoosterActivatedEvent;

	public static Observable OnBoosterClosedEvent;

	public static Observable<BoostersTypes> OnBoosterExecutedEvent;

	public static Observable<BoostersTypes> OnBoosterExecutionStartedEvent;

	public static Observable OnUpdateWaterCanBoostersView;

	public static Observable OnUpdateRespawnTraysBoostersView;

	public static Observable OnUpdateSwapSlotsBoostersView;

	public static Observable OnUpdateHorizontalRocketBoostersView;

	public static Observable OnUpdateVerticalRocketBoostersView;

	public static Observable OnUpdateHorizontalVerticalRocketBoostersView;

	public static Observable OnUpdateBombBoostersView;

	public static Observable OnUpdateRowSortBoostersView;

	public static Observable OnUpdateColumnSortBoostersView;

	public static Observable OnUpdateItemBonusScoreBoostersView;

	public static Observable OnUpdatePitchForkBoostersView;

	public static Observable OnUpdateTrovelBoostersView;

	public static Observable OnUpdatePaintBrushBoosterView;

	public static Observable OnUpdateSmallFertilizerBoosterView;

	public static Observable OnUpdateLargeFertilizerBoosterView;

	public static Observable OnUpdateMagicPotBoosterView;

	public static Observable OnUpdateSuperMagicPotBoosterView;

	public static Observable OnUpdateWheelBarrowBoosterView;

	public static Observable OnUpdateSlotUnlockBoostersView;

	public static Observable OnUpdateSexyPotBoostersView;

	public static Observable<bool> OnCameraMoveOutEvent;

	public static Observable OnLevelFailCameraMoveOutEvent;

	public static Observable OnGridBoosterViewCameraMoveOutEvent;

	public static Observable<bool> OnGridBoosterViewCameraMoveInEvent;

	public static Observable<bool> OnTrayBoosterViewCameraMoveInEvent;

	public static Observable OnTrayBoosterViewCameraMoveOutEvent;

	public static Observable<bool> OnSetGiftStateEvent;

	public static Observable OnSet3DCameraOnTopEvent;

	public static Observable OnSetUICameraOnTopEvent;

	public static Observable<CameraReference> OnAddCameraInStackEvent;

	public static Observable<bool> OnSetButterflyCameraState;

	public static Observable OnUpdateCardsChestView;

	public static Observable OnShowCardsChestTutorial;

	public static Observable OnCardsChestTutorialCompleted;

	public static Observable<bool> OnIsCardsChestTutorialActive;

	public static Observable<int> OnUpdateCashEvent;

	public static Observable<CollectablesData> OnUpdateMarketCashView;

	public static Observable<CollectablesData> OnUpdateGameplayCashView;

	public static Observable<CollectablesData> OnUpdateMainMenuCashView;

	public static Observable<CharacterAnimationType> OnPlayCharacterAnimation;

	public static Observable<CharacterActionType> OnPlayCharacterAction;

	public static Observable<int> OnSetupGameplayEnvironment;

	public static Observable OnFireFlowerUnlockedEvent;

	public static Observable<int> OnFlowerUpgradeEvent;

	public static Observable<bool> OnSetFlowerUpgradeCameraState;

	public static Observable OnShowFlowerUpgradeMenuTutorial;

	public static Observable OnUpdateFlowerShopButtonNotificationEvent;

	public static Observable<bool> OnUpdateFlowerMenuViewEvent;

	public static Observable<bool> OnUpdateGameplayHudView;

	public static Observable OnUpdateFlowerUpgradeButtonStateEvent;

	public static Observable<bool> OnShowTutorial;

	public static Observable<bool> IsGameplayTutorialActive;

	public static Observable<GameplayHudData> OnShowGamePlayHud;

	public static Observable<bool> OnShowHighScoreCrown;

	public static Observable<bool> OnShowGiftTutorialEvent;

	public static Observable<bool> OnSetGameplayHudBlockerEvent;

	public static Observable OnClickRetry;

	public static Observable<EventTimeData> OnEventTimerUpdate;

	public static Observable OnEventStarted;

	public static Observable OnEventEnded;

	public static Observable<HudEventIntroAnimationData> OnShowEventIntroAnimation;

	public static Observable OnAllLiveOpsOffersPurchased;

	public static Observable<int> OnLiveOpsOfferRewardClaimed;

	public static Observable<bool> IsDailyFreeGiftAvailable;

	public static Observable<ProductName, Vector3> OnGetInAppPosition;

	public static Observable<bool> OnMarketViewShownEvent;

	public static Observable OnUpdateMarketButtonNotificationEvent;

	public static Observable<MarketCardsAnimationData> OnCardsPurchased;

	public static Observable<MarketViewData> OnShopShownFromMainMenu;

	public static Observable OnSkipItOfferPurchasedEvent;

	public static Observable<SkipAdsPurchaseViewModel> OnSkipItNotifyViewEvent;

	public static Observable OnUpdateNewOffer;

	public static Observable OnShowOfferEvent;

	public static Observable<CollectableViewTriggerModel> OnCollectableViewClicked;

	public static Observable<CooldownStateDataModel> OnOfferCooldownStateChanged;

	public static Observable OnIncrementMetaId;

	public static Observable OnMissionCompletedEvent;

	public static Observable OnUpdateMissionCenterButtonView;

	public static NotificationSignature00 SendNotification;

	public static NotificationSignature01 SendSocialNotification;

	public static Observable OnSchedulePTournamentNotification;

	public static Observable<bool> OnSetOverlayState;

	public static Observable MoveOverlayForTray;

	public static Observable OnPassiveBoosterAvtivated;

	public static Observable<PassiveBoosterData> OnPassiveBoosterTick;

	public static Observable<bool> OnUpdateBoosterCTA;

	public static Observable OnPowerUpsEquipped;

	public static Observable OnShowPowerUpTutorial;

	public static Observable<BoostersAnimationData> OnUpdateBoostersAnimationEvent;

	public static Observable<CollectablesData> OnAddCardsOnSpinner;

	public static Observable<int> OnSetCash;

	public static Observable<ExperienceDataModel> OnAddExperienceData;

	public static Observable<ExperienceViewDataModel> OnUpdateExperienceEvent;

	public static Observable<int> OnUpdatePlayerLevelEvent;

	public static Observable<float> OnUpdateScore;

	public static Observable OnLevelFailedEvent;

	public static Observable<CollectablesData> OnUpdateScoreWithCollectableAnimation;

	public static Observable<LevelUpData> OnLevelUpEvent;

	public static Observable OnLevelResetEvent;

	public static Observable OnLevelUpGiftBoxOpened;

	public static Observable<Vector3> OnGetSlotPosition;

	public static Observable<bool> OnIsBoardEmpty;

	public static Observable<bool> OnIsBoardFull;

	public static Observable<bool> OnIsGiftSpawnedEvent;

	public static Observable<float> OnUpdateHighScoreEvent;

	public static Observable OnRefreshTraysEvent;

	public static Observable OnRefreshTraysTutorialClickedEvent;

	public static Observable OnShowRefreshTraysTutorialEvent;

	public static Observable<bool> OnSetReviveParticlesState;

	public static Observable OnUpdateSPPNotificationEvent;

	public static Observable OnBloomPassPurchased;

	public static Observable<int> OnUpdateSkipAdsEvent;

	public static Observable<SkipAdsAnimationData> OnUpdateSkipAdsAnimationEvent;

	public static Observable<bool> OnSkipAdsPurchaseViewShownEvent;

	public static Observable OnPrintBoosterFTUELogs;

	public static Observable OnStarterPackPurchased;

	public static Observable<bool> IsStarterPackAvailable;

	public static Observable<bool> OnStarterPackAvailabilityChangedEvent;

	public static Observable<bool> IsStarterPackPurchased;

	public static Observable OnMoveTraysToGridBoosterState;

	public static Observable MoveTraysBackToNormalState;

	public static Observable OnForcePutTrayBack;

	public static Observable<bool> OnTraysWarningActivatedEvent;

	public static Observable<int> OnGetAvailableTraysCount;

	public static Observable OnForceTrayBlockerOn;

	public static Observable OnTutorialMaskActivatedEvent;

	public static void DoFireApplicationPauseEvent()
	{
	}

	public static void DoFireApplicationResumeEvent()
	{
	}

	public static void DoFireUpdateCurrencyEvent(Currency currency)
	{
	}

	public static void DoFireLoadHomeViewEvent()
	{
	}

	public static void DoFirePreLoadGameEvent()
	{
	}

	public static void DoFireLoadGameEvent()
	{
	}

	public static void DoFireUnLoadGameEvent()
	{
	}

	public static void DoFireStartGameEvent()
	{
	}

	public static void DoFireFailGameEvent()
	{
	}

	public static void DoFireGameEndEvent()
	{
	}

	public static void DoFireShopCompleteEvent()
	{
	}

	public static void DoFireGameCompleteEvent()
	{
	}

	public static void DoFireGameSkipEvent()
	{
	}

	public static void DoFireRestartGameEvent()
	{
	}

	public static void DoFireGameplaySceneLoadedEvent()
	{
	}

	public static void DoFireStopGameEvent()
	{
	}

	public static void DoFireSetDishStateEvent(bool state)
	{
	}

	public static void DoFireGameMenuPanelChangedEvent(int index)
	{
	}

	public static void DoFireGoToShopPanelEvent(MarketViewData marketData)
	{
	}

	public static void DoFireGoToFlowerMenuPanelEvent()
	{
	}

	public static void DoFireGoToMainMenuPanelEvent()
	{
	}

	public static ActionButton DoFireGetActiveMenuEvent()
	{
		return default(ActionButton);
	}

	public static ActionButtonViewData DoFireGetHomeButtonRect()
	{
		return default(ActionButtonViewData);
	}

	public static ActionButtonViewData DoFireGetFlowerUpgradesButtonRectEvent()
	{
		return default(ActionButtonViewData);
	}

	public static void DoFireAddGameLevelDataEvent(GameLevelDataModel levelDataModel)
	{
	}

	public static GameLevelDataModel DoFireGetGameLevelDataEvent(GameDataContainer gameData)
	{
		return default(GameLevelDataModel);
	}

	public static void DoFireAddLevelDataEvent(LevelDataModel levelDataModel)
	{
	}

	public static LevelDataModel DoFireGetLevelDataEvent(int levelId)
	{
		return default(LevelDataModel);
	}

	public static void DoFireLevelFailRetry()
	{
	}

	public static LevelDataModel DoFireGetGameToAssignEvent(int rowId)
	{
		return default(LevelDataModel);
	}

	public static LevelDataModel DoFireGetCurrentGameDataEvent()
	{
		return default(LevelDataModel);
	}

	public static bool DoFireIsVipGamePlayedEvent()
	{
		return false;
	}

	public static void DoFireSetVipGameIntevalEvent(int interval)
	{
	}

	public static int DoFireGetTotalVipLevelsEvent()
	{
		return 0;
	}

	public static int DoFireGetTotalLevelsEvent()
	{
		return 0;
	}

	public static int DoFireGetCurrentLevelEvent()
	{
		return 0;
	}

	public static int DoFireGetGameLevelEvent(GameType game)
	{
		return 0;
	}

	public static void DoFireUpdateLevelProgressEvent()
	{
	}

	public static void DoFireGameLoadingCompleteEvent()
	{
	}

	public static Vector3 DoFireGetCoinAnimPositionEvent()
	{
		return default(Vector3);
	}

	public static void DoFireShowViewEvent(UIViewDataModel uIViewDataModel)
	{
	}

	public static void DoFireHideViewEvent()
	{
	}

	public static void DoFireHideViewEvent(Views id)
	{
	}

	public static void DoFireHideAllViewsEvent()
	{
	}

	public static int DoFireGetOpenViewsCountEvent()
	{
		return 0;
	}

	public static UICameraData DoFireGetUICameraEvent()
	{
		return default(UICameraData);
	}

	public static void DoFireSetMetaCameraStateEvent(bool state)
	{
	}

	public static bool DoFireIsViewActiveEvent(Views id)
	{
		return false;
	}

	public static bool DoFireIsViewOnTopEvent(Views id)
	{
		return false;
	}

	public static bool DoFireIsOnlyViewActiveEvent(Views id)
	{
		return false;
	}

	public static void DoFireSetGraphicRaycasterStateEvent(bool active)
	{
	}

	public static UICanvasGroupData DoFireGetUICanvasGroup()
	{
		return default(UICanvasGroupData);
	}

	public static void DoFireShowFloaterEvent(FloaterText text)
	{
	}

	public static void DoFireShowCustomFloaterEvent(CustomFloaterText text)
	{
	}

	public static void DoFirePlayConfettiEvent()
	{
	}

	public static bool DoFireShowAdEvent(AdEventData eventData)
	{
		return false;
	}

	public static bool DoFireIsRvLoadedEvent()
	{
		return false;
	}

	public static void DoFireInterstitialClosedOfferEvent()
	{
	}

	public static void DoFireInterstitialClosedEvent(InterstitialClosedEventData interstitialClosedEventData)
	{
	}

	public static void DoFireResetAdTimersEvent()
	{
	}

	public static void DoFireAdShownEvent(AdShownEventData eventData)
	{
	}

	public static void DoFireHideAdEvent(AdEventData eventData)
	{
	}

	public static void DoFireBannerAdStateUpdatedEvent(bool isShown)
	{
	}

	public static void DoFireBannerShownAfterInterEvent()
	{
	}

	public static void DoFireOnLoadBannerAdEvent()
	{
	}

	public static void DoFireResetInGameInterTimeEvent(bool hardReset)
	{
	}

	public static void DoFireAdNotAvailableEvent()
	{
	}

	public static void DoFireRewardedVideoViewOpenEvent(AdPlacementEventData placement)
	{
	}

	public static void DoFireInterstitialShownEvent(AdPlacementEventData placement)
	{
	}

	public static void DoFireShowRewardedAdUIEvent(AdPlacementEventData placement)
	{
	}

	public static void DoFireNoAdsOfferAvailedEvent(AdPlacementEventData placement)
	{
	}

	public static void DoFireRewardedVideoAdShownEvent(RVShownEventData placement)
	{
	}

	public static void DoFireAppOpenAdClosedEvent()
	{
	}

	public static bool DoFireToggleAmazonTestAdsEvent()
	{
		return false;
	}

	public static void DoFireEnableAdjustTestAdsEvent()
	{
	}

	public static void DoFireOnFetchedFirebaseData()
	{
	}

	public static void DoFireHelpShiftViewOpenedEvent()
	{
	}

	public static InAppRewardDataEvent DoFireGetInAppRewardDataEvent(InAppIdDataEvent inAppIdDataEvent)
	{
		return default(InAppRewardDataEvent);
	}

	public static void DoFireRemoveAdsPurchasedEvent()
	{
	}

	public static void DoFireValidateRemoveAdsPurchased()
	{
	}

	public static GetAppreciationBannerEventData DoFireGetAppreciationBannerViewEvent()
	{
		return default(GetAppreciationBannerEventData);
	}

	public static GetStreakBannerEventData DoFireGetStreakBannerViewEvent()
	{
		return default(GetStreakBannerEventData);
	}

	public static void DoFireUpdateScoreView(CollectablesData data)
	{
	}

	public static void DoFireUpdateCoinView(CollectablesData data)
	{
	}

	public static void DoFireShowComboView(CollectablesData data)
	{
	}

	public static void DoFireShowNewHighScoreBannerEvent()
	{
	}

	public static void DoFireSetCanShowHighScoreBannerEvent()
	{
	}

	public static BoingCollidersDataModel DoFireGetBoingCollidersEvent()
	{
		return default(BoingCollidersDataModel);
	}

	public static void DOFireShowButterflyTutorial(Vector3 butterflyPosition)
	{
	}

	public static void DOFireButterflyTutorialCompleted()
	{
	}

	public static void DoFirePowerUpSpinnerClosed()
	{
	}

	public static void DoFireButterflySpawnedEvent()
	{
	}

	public static void DoFireButterflyExitEvent()
	{
	}

	public static void DoFireOnScoreUpdatedForButterflyEvent(float score)
	{
	}

	public static bool DoFireGetButterflyUnlockedEvent()
	{
		return false;
	}

	public static void DoFireUpdateButterflySpawnTargetScoreEvent()
	{
	}

	public static bool DoFireIsButterlyTutorialActiveEvent()
	{
		return false;
	}

	public static void DoFireButterflyDropDespawnTimeUpdateEvent(int time)
	{
	}

	public static void DoFireUpdateBoosterDropConfigEvent(BoosterDropConfig config)
	{
	}

	public static void DOFireShowBoostersTutorial(BoostersTutorialDataModel boostersTutorialDataModel)
	{
	}

	public static void DOFireBoostersTutorialCompleted()
	{
	}

	public static void DOFireShowDropBoosterTutorial(BoostersTutorialDataModel boostersTutorialDataModel)
	{
	}

	public static void DoFireHideBoosterInfoHeaderEvent()
	{
	}

	public static void DoFireBoosterActivatedEvent(BoosterActivationDataModel dataModel)
	{
	}

	public static void DOFireBoosterClosedEvent()
	{
	}

	public static void DoFireBoosterExecutedEvent(BoostersTypes type)
	{
	}

	public static void DoFireBoosterExecutionStartedEvent(BoostersTypes type)
	{
	}

	public static void DoFireUpdateWaterCanBoostersViewEvent()
	{
	}

	public static void DoFireUpdateRespawnBoostersViewEvent()
	{
	}

	public static void DoFireUpdateSwapSlotsBoostersViewEvent()
	{
	}

	public static void DoFireUpdateHorizontalRocketBoostersViewEvent()
	{
	}

	public static void DoFireUpdateVerticalRocketBoostersViewEvent()
	{
	}

	public static void DoFireUpdateHorizontalVerticalRocketBoostersViewEvent()
	{
	}

	public static void DoFireUpdateBombBoostersViewEvent()
	{
	}

	public static void DoFireUpdateRowSortBoostersViewEvent()
	{
	}

	public static void DoFireUpdateColumnSortBoostersViewEvent()
	{
	}

	public static void DoFireUpdateItemBonusScoreBoostersViewEvent()
	{
	}

	public static void DoFireUpdatePitchForkBoostersViewEvent()
	{
	}

	public static void DoFireUpdateTrovelBoostersViewEvent()
	{
	}

	public static void DoFireUpdatePaintBrushBoostersViewEvent()
	{
	}

	public static void DoFireUpdateSmallFertilizerBoostersViewEvent()
	{
	}

	public static void DoFireUpdateLargeFertilizerBoostersViewEvent()
	{
	}

	public static void DoFireUpdateMagicPotBoostersViewEvent()
	{
	}

	public static void DoFireUpdateSuperMagicPotBoostersViewEvent()
	{
	}

	public static void DoFireUpdateWheelBarrowBoosterViewEvent()
	{
	}

	public static void DoFireUpdateSlotUnlockBoostersViewEvent()
	{
	}

	public static void DoFireUpdateSexyPotBoostersViewEvent()
	{
	}

	public static void DoFireCameraMoveOutEvent(bool state = false)
	{
	}

	public static void DoFireLevelFailCameraMoveOutEvent()
	{
	}

	public static void DoFireGridBoosterViewCameraMoveOutEvent()
	{
	}

	public static void DoFireGridBoosterViewCameraMoveInEvent(bool state = false)
	{
	}

	public static void DoFireTrayBoosterViewCameraMoveInEvent(bool state = false)
	{
	}

	public static void DoFireTrayBoosterViewCameraMoveOutEvent()
	{
	}

	public static void DoFireSetGiftStateEvent(bool state)
	{
	}

	public static void DoFireSet3DCameraOnTopEvent()
	{
	}

	public static void DoFireSetUICameraOnTopEvent()
	{
	}

	public static void DoFireAddCameraInStackEventEvent(CameraReference camera)
	{
	}

	public static void DoFireSetButterflyCameraStateEvent(bool state)
	{
	}

	public static void DoFireUpdateCardsChestViewEvent()
	{
	}

	public static void DOFireShowCardsChestTutorialEvent()
	{
	}

	public static void DOFireCardsChestTutorialCompleted()
	{
	}

	public static bool DoFireIsCardsChestTutorialActiveEvent()
	{
		return false;
	}

	public static void DoFireUpdateCashEvent(int cash)
	{
	}

	public static void DoFireUpdateMarketCashViewEvent(CollectablesData data)
	{
	}

	public static void DoFireUpdateGameplayCashViewEvent(CollectablesData data)
	{
	}

	public static void DoFireUpdateMainMenuCashViewEvent(CollectablesData data)
	{
	}

	public static void DoFirePlayCharacterAnimationEvent(CharacterAnimationType animationType)
	{
	}

	public static void DoFirePlayCharacterActionEvent(CharacterActionType actionType)
	{
	}

	public static void DoFireSetupGameplayEnvironmentEvent(int index)
	{
	}

	public static void DoFireFlowerUnlockedEvent()
	{
	}

	public static void DoFireFlowerUpgradeEvent(int flowerId)
	{
	}

	public static void DoFireSetFlowerUpgradeCameraStateEvent(bool state)
	{
	}

	public static void DOFireShowFlowerUpgradeMenuTutorial()
	{
	}

	public static void DoFireUpdateFlowerShopButtonNotificationEvent()
	{
	}

	public static void DOFireUpdateFlowerMenuViewEvent(bool forceUpdate)
	{
	}

	public static void DOFireUpdateGameplayHudViewEvent(bool isTurboMode)
	{
	}

	public static void DOFireUpdateFlowerUpgradeButtonStateEvent()
	{
	}

	public static void DoFireShowTutorialEvent(bool isTutorialActive)
	{
	}

	public static bool DoFireIsGameplayTutorialActiveEvent()
	{
		return false;
	}

	public static void DoFireShowGamePlayHudEvent(GameplayHudData data)
	{
	}

	public static void DoFireShowHighScoreCrownEvent(bool state)
	{
	}

	public static void DoFireShowGiftTutorialEvent(bool show)
	{
	}

	public static void DOFireSetGameplayHudBlockerEvent(bool show)
	{
	}

	public static void DoFireRetryClicked()
	{
	}

	public static void DoFireEventTimerUpdate(EventTimeData score)
	{
	}

	public static void DoFireEventStarted()
	{
	}

	public static void DoFireEventEnded()
	{
	}

	public static void DoFireShowEventIntroAnimationOnHud(HudEventIntroAnimationData hudEventIntroAnimationData)
	{
	}

	public static void DoFireAllLiveOpsOffersPurchasedEvent()
	{
	}

	public static void DoFireLiveOpsOfferRewardClaimedEvent(int coinsReward)
	{
	}

	public static bool DoFireIsDailyFreeGiftAvailableEvent()
	{
		return false;
	}

	public static Vector3 DoFireGetInAppPositionEvent(ProductName id)
	{
		return default(Vector3);
	}

	public static void DoFireMarketShownEvent(bool state)
	{
	}

	public static void DoFireUpdateMarketButtonNotificationEvent()
	{
	}

	public static void DoFireCardsPurchasedEvent(MarketCardsAnimationData data)
	{
	}

	public static void DoFireShopShownFromMainMenuEvent(MarketViewData marketData)
	{
	}

	public static void DoFireSkipItOfferPurchasedEvent()
	{
	}

	public static void DoFireSkipItNotifyViewEvent(SkipAdsPurchaseViewModel dataModel)
	{
	}

	public static void DoFireOnUpdateNewOfferEvent()
	{
	}

	public static void DoFireShowOfferEvent()
	{
	}

	public static void DoFireCollectableViewClickedEvent(CollectableViewTriggerModel model)
	{
	}

	public static void DoFireOfferCooldownStateChangedEvent(CooldownStateDataModel model)
	{
	}

	public static void DoFireIncrementMetaIdEvent()
	{
	}

	public static void DoFireMissionCompletedEvent()
	{
	}

	public static void DoFireUpdateMissionCenterButtonView()
	{
	}

	public static void DoFireSendNotification(LocalNotificationSO localNotification, NotificationText notificationText)
	{
	}

	public static void DoFireSendSocialNotification(NotificationId notificationId, int remainingTime)
	{
	}

	public static void DoFireSchedulePTournamentNotificationsEvent()
	{
	}

	public static void DoFireSetOverlayStateEvent(bool status)
	{
	}

	public static void DoFireMoveOverlayForTrayEvent()
	{
	}

	public static void DoFirePassiveBoosterActivated()
	{
	}

	public static void DoFirePassiveBoosterTick(PassiveBoosterData passiveBoosterData)
	{
	}

	public static void DoFireUpdateBoosterCTAEvent(bool state)
	{
	}

	public static void DoFirePowerUpsEquippedEvent()
	{
	}

	public static void DoFireShowPowerUpTutorialEvent()
	{
	}

	public static void DoFireUpdateBoostersAnimationEvent(BoostersAnimationData skipAdsAnimationData)
	{
	}

	public static void DoFireAddCardsOnSpinnerEvent(CollectablesData data)
	{
	}

	public static void DoFireSetCashEvent(int cash)
	{
	}

	public static void DoFireAddExperienceDataEvent(ExperienceDataModel experienceDataModel)
	{
	}

	public static void DoFireUpdateExperienceEvent(ExperienceViewDataModel dataModel)
	{
	}

	public static void DoFireUpdatePlayerLevelEvent(int level)
	{
	}

	public static void DoFireUpdateScoreEvent(float score)
	{
	}

	public static void DoFireLevelFailedEvent()
	{
	}

	public static void DoFireUpdateScoreWithCollectableAnimationEvent(CollectablesData data)
	{
	}

	public static void DoFireLevelUpEvent(LevelUpData levelUpData)
	{
	}

	public static void DoFireLevelResetEvent()
	{
	}

	public static void DoFireLevelUpGiftBoxOpened()
	{
	}

	public static Vector3 DoFireGetSlotPositionEvent()
	{
		return default(Vector3);
	}

	public static bool DoFireIsBoardEmptyEvent()
	{
		return false;
	}

	public static bool DoFireIsBoardFullEvent()
	{
		return false;
	}

	public static bool DoFireIsGiftSpawnedEvent()
	{
		return false;
	}

	public static void DoFireUpdateHighScoreEvent(float highScore)
	{
	}

	public static void DoFireRefreshTraysEvent()
	{
	}

	public static void DoFireRefreshTraysTutorialClickedEvent()
	{
	}

	public static void DoFireShowRefreshTraysTutorialEvent()
	{
	}

	public static void DoFireSetReviveParticlesStateEvent(bool sttae)
	{
	}

	public static void DoFireUpdateSPPNotificationEvent()
	{
	}

	public static void DoFireBloomPassPurchasedEvent()
	{
	}

	public static void DoFireUpdateSkipAdsEvent(int count)
	{
	}

	public static void DoFireUpdateSkipAdsAnimationEvent(SkipAdsAnimationData skipAdsAnimationData)
	{
	}

	public static void DoFireSkipAdsPurchaseViewShownEvent(bool state)
	{
	}

	public static void DOFirePrintBoosterFTUELogs()
	{
	}

	public static void DoFireStarterPackPurchasedEvent()
	{
	}

	public static bool DoFireIsStarterPackAvailableEvent()
	{
		return false;
	}

	public static void DoFireOnStarterPackAvailabilityChangedEvent(bool state)
	{
	}

	public static bool DoFireIsStarterPackPurchasedEvent()
	{
		return false;
	}

	public static void DoFireMoveTraysToGridBoosterStateEvent()
	{
	}

	public static void DoFireMoveTraysBackToNormalStateStateEvent()
	{
	}

	public static void DoFireForcePutTrayBackEvent()
	{
	}

	public static void DoFireTraysWarningActivatedEvent(bool state)
	{
	}

	public static int DoFireGetAvailableTraysCountEvent()
	{
		return 0;
	}

	public static void DoFireForceTrayBlockerOn()
	{
	}

	public static void DoFireTutorialMaskActivatedEvent()
	{
	}
}
