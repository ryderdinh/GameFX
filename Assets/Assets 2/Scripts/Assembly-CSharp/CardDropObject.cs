using UnityEngine;

public class CardDropObject : BaseStackDropObject
{
	[SerializeField]
	private Material _cardMaterial;

	[SerializeField]
	private AllItemsObject _allItems;

	private static readonly int BaseMap;

	private static readonly int EmissionMap;

	public override void DropBooster(BoosterDropData dropData)
	{
	}

	private int GetStackID(int value)
	{
		return 0;
	}

	private void UpdateTexture(Texture texture)
	{
	}
}
