public class PieceSortController : BaseGameController<PieceSortRefs>, IBoosters, IButterfly, IBaseBoosterProvider, ITurboMode
{
	private PieceSortLevelDataModel _dataModel;

	private bool _isGameLoaded;

	private int _levelAttemptCount;

	private float _lastFixedFrameTime;

	private BoostersTutorialController _boostersTutorialController;

	public override void Initialize()
	{
	}

	private void FixedUpdate()
	{
	}

	public override void LoadGame(ILevelData dataModel)
	{
	}

	public override void UnLoadGame()
	{
	}

	public override void PostLoadGame()
	{
	}

	public override void StartGame()
	{
	}

	public override void CompleteGame()
	{
	}

	public override void FailGame()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	private void GameEnd()
	{
	}

	private void ShopComplete()
	{
	}

	private void ResetState()
	{
	}

	private void ResetGridAndTray()
	{
	}

	private void ForceResetData()
	{
	}

	private void OnLevelFailRetry()
	{
	}

	private void RestartGame()
	{
	}

	void IBoosters.ExecuteWateringCan()
	{
	}

	void IBoosters.CloseWateringCan()
	{
	}

	void IBoosters.ExecuteRespawnTrays()
	{
	}

	void IBoosters.ExecutePitchFork()
	{
	}

	void IBoosters.ExecuteSuperWateringCan()
	{
	}

	void IBoosters.ExecuteSwapSlots()
	{
	}

	void IBoosters.CloseSwapSlots()
	{
	}

	void IBoosters.ExecuteHorizontalRocket()
	{
	}

	void IBoosters.CloseHorizontalRocket()
	{
	}

	void IBoosters.ExecuteVerticalRocket()
	{
	}

	void IBoosters.CloseVerticalRocket()
	{
	}

	void IBoosters.ExecuteHorizontalVerticalRocket()
	{
	}

	void IBoosters.CloseHorizontalVerticalRocket()
	{
	}

	void IBoosters.ExecuteBomb()
	{
	}

	void IBoosters.CloseBomb()
	{
	}

	void IBoosters.ExecuteRowSort()
	{
	}

	void IBoosters.ExecuteColumnSort()
	{
	}

	void IBoosters.CloseTrovel()
	{
	}

	void IBoosters.ExecuteTrovel()
	{
	}

	void IBoosters.ClosePaintBrush()
	{
	}

	void IBoosters.ExecutePaintBrush(int cakeID)
	{
	}

	void IBoosters.ExecuteSmallFertilizer()
	{
	}

	void IBoosters.CloseSmallFertilizer()
	{
	}

	void IBoosters.ExecuteLargeFertilizer()
	{
	}

	void IBoosters.ExecuteMagicPot(int cakeID)
	{
	}

	void IBoosters.ExecuteSuperMagicPot(int cakeID)
	{
	}

	void IBoosters.ExecuteItemBonusScore(int scoreToAdd)
	{
	}

	void IBoosters.ExecuteWheelBarrow()
	{
	}

	void IBoosters.AddFlowerTierUpdateCards(int flowerID, int cardsCount)
	{
	}

	void IBoosters.ExecuteDishTierUpdate()
	{
	}

	void IBoosters.BoosterExecuted()
	{
	}

	void IBoosters.BoosterExecutionStarted()
	{
	}

	float IButterfly.GetBoardState()
	{
		return 0f;
	}

	public Slot GetRandomSlot(SlotState slotState)
	{
		return null;
	}

	void IButterfly.ForceTrayBackInPlace()
	{
	}

	void IButterfly.ButterflyTutorialActivated()
	{
	}

	void IButterfly.ButterflyTutorialCompleted()
	{
	}

	void IBoosters.ExecuteSlotUnlock()
	{
	}

	void IBoosters.CloseSlotUnlock()
	{
	}

	void IBoosters.ExecuteSexyPot()
	{
	}

	void IBoosters.CloseSexyPot()
	{
	}

	private void ShowInAppReview(BoostersTypes type)
	{
	}

	void ITurboMode.TurboModeActivated()
	{
	}

	private void ApplyTurboMode(bool activate)
	{
	}

	void ITurboMode.TurboModeDeactivated()
	{
	}

	void ITurboMode.UpdateTurboModeView(float duration)
	{
	}

	void ITurboMode.ShowTurboModeTutorial()
	{
	}

	void ITurboMode.UpdateTurboModeUnlockedView()
	{
	}
}
