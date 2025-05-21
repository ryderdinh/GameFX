public interface IBoosters
{
	void ExecuteWateringCan();

	void CloseWateringCan();

	void ExecuteRespawnTrays();

	void ExecuteSuperWateringCan();

	void ExecuteSwapSlots();

	void CloseSwapSlots();

	void ExecuteHorizontalRocket();

	void CloseHorizontalRocket();

	void ExecuteVerticalRocket();

	void CloseVerticalRocket();

	void ExecuteHorizontalVerticalRocket();

	void CloseHorizontalVerticalRocket();

	void ExecuteBomb();

	void CloseBomb();

	void ExecuteRowSort();

	void ExecuteColumnSort();

	void ExecutePitchFork();

	void ExecuteTrovel();

	void CloseTrovel();

	void ExecutePaintBrush(int cakeID);

	void ClosePaintBrush();

	void ExecuteSmallFertilizer();

	void CloseSmallFertilizer();

	void ExecuteLargeFertilizer();

	void ExecuteMagicPot(int cakeID);

	void ExecuteSuperMagicPot(int cakeID);

	void ExecuteItemBonusScore(int scoreToAdd);

	void ExecuteWheelBarrow();

	void ExecuteSlotUnlock();

	void CloseSlotUnlock();

	void AddFlowerTierUpdateCards(int flowerID, int cardsCount);

	void ExecuteSexyPot();

	void CloseSexyPot();

	void ExecuteDishTierUpdate();

	void BoosterExecuted();

	void BoosterExecutionStarted();
}
