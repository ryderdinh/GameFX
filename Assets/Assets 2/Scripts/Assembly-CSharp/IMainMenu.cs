public interface IMainMenu
{
	void SetMainMenuState(bool status);

	void UpdateMetaData(string name, BestRecordModel progressData);

	void PlayButtonClicked();
}
