using UnityEngine;

public interface IItemUpgradeObject
{
	bool CanUpdateTier();

	int CardsRequiredToUnlockNextTier();

	int CostRequiredToUnlockNextTier();

	void UpdateTier();

	int FlowerId();

	Sprite CardSprite();

	float Score();

	int Tier();
}
