public struct BoosterSelectionData
{
	public bool CanSelect;

	public int SlotId;

	public int SecondarySlotId;

	public BoosterSelectionData(bool canSelect, int slotId, int secondarySlotId)
	{
		CanSelect = false;
		SlotId = 0;
		SecondarySlotId = 0;
	}
}
