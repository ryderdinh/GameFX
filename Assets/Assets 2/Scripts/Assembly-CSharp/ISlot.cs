public interface ISlot
{
	void SlotClicked(Slot slot);

	void EmptySlotClicked(Slot slot);

	void SlotDrag(Slot slot);

	void SetMovingSlot(int id);

	bool SnapSlotOnGrid(bool canSnap);

	int MovingSlotID();
}
