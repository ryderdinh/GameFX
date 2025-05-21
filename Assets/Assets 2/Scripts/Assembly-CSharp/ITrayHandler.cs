using System.Collections.Generic;
using DB;
using UnityEngine;

public interface ITrayHandler
{
	bool SnapTrayOnGrid(Vector2 touchPosition, Tray tray);

	void TrayIsMoving(Tray tray);

	bool CanPlaceTraysOnGrid(List<Tray> trays, bool isStart = false);

	int AvailableSlots();

	void SafeCheckGrid();

	bool CanPlaceDualTray(Tray trays);

	bool CanPlaceTray(TrayType trayType);

	void UnhighlightPreviousTiles();

	ArrayArrayInt GetState();

	bool AllSlotsOccupied();
}
