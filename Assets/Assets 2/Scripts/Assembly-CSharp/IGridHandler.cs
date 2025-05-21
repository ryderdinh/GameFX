using System.Collections.Generic;
using UnityEngine;

public interface IGridHandler
{
	void GridSortingCompleted();

	void GridStateNotUpdated();

	Vector3 GetTutorialTrayPosition();

	bool IsValidMoveLeft();

	void BoosterAppliedOnGrid();

	List<Tray> GetTrays();

	Vector3 GetEmptySlotPosition();
}
