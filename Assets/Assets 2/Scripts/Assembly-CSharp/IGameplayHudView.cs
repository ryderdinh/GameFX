public interface IGameplayHudView
{
	void ShowLevelCompleteBanner(int level);

	void ShowCheckPointBanner();

	void UpdateHud(int index);
}
