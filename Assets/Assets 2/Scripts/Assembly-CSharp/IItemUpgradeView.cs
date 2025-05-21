using UnityEngine;

public interface IItemUpgradeView
{
	void ItemUpgraded(FlowerType flowerType, Vector3 position, float score);

	void ResetAllFlowerUpgradesButtonState();
}
