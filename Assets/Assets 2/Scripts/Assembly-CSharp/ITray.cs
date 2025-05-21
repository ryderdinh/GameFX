public interface ITray
{
	void SetMovingTray(int id);

	void ResetMovingTray();

	bool SnapTrayOnGrid();

	void TrayClicked(Tray tray);
}
