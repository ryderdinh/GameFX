using UnityEngine;

public class PaintBrushDropObject : BoosterDropObject
{
	[SerializeField]
	private SkinnedMeshRenderer _renderer;

	[SerializeField]
	private AllItemsObject _allItems;

	public override void DropBooster(BoosterDropData dropData)
	{
	}

	private void SetBristlesMaterialColor(Color color)
	{
	}
}
