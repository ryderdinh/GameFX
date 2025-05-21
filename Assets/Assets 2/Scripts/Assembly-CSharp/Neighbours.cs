using System.Collections.Generic;

public class Neighbours
{
	private int _maxSlots;

	private int _columns;

	private List<Slot> _slots;

	private List<int> _neighbors;

	public Neighbours(int maxSlots, int columns, List<Slot> slots)
	{
	}

	public bool IsHorizontalNeighbour(int index)
	{
		return false;
	}

	public bool IsVerticalNeighbour(int index)
	{
		return false;
	}

	public List<int> GetNeighbours(int slotId)
	{
		return null;
	}

	public static List<int> GetNeighbours(int slotId, int columns, int maxSlots)
	{
		return null;
	}

	public static List<int> GetDiagonalNeighbours(int slotId, int columns, int rows)
	{
		return null;
	}

	public static List<int> GetVerticalNeighbours(int slotId, int columns, int maxSlots)
	{
		return null;
	}

	public static List<int> GetHorizontalNeighbours(int slotId, int columns, int maxSlots)
	{
		return null;
	}
}
