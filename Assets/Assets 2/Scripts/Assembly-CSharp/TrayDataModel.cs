using System.Collections.Generic;

public struct TrayDataModel
{
	public TrayType TrayType;

	public List<List<int>> Dishes;

	public TrayDataModel(TrayType trayType, List<List<int>> dishes)
	{
		TrayType = default(TrayType);
		Dishes = null;
	}

	public void ResetDishes()
	{
	}

	public bool Contains(int id)
	{
		return false;
	}
}
