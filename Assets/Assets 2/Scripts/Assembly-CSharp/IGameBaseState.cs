public interface IGameBaseState
{
	void PreLoadGame();

	void LoadGame();

	void PostLoadGame();

	void StartGame();

	void GameStepComplete();

	void CompleteGame();

	void FailGame();

	void UnloadGame();
}
