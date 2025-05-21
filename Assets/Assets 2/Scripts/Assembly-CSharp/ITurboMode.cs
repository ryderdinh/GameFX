public interface ITurboMode
{
	void TurboModeActivated();

	void TurboModeDeactivated();

	void UpdateTurboModeView(float duration = 0.35f);

	void UpdateTurboModeUnlockedView();

	void ShowTurboModeTutorial();
}
