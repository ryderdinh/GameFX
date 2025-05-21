public interface IBoosterSpinner
{
	void BoosterSelected(ApplyBoosterData applyBoosterData);

	bool IsFTUE();

	bool IsBestBooster();

	bool IsIncrementFTUELevel();

	void HideSpinnersOnSelection(int spinnerID);
}
