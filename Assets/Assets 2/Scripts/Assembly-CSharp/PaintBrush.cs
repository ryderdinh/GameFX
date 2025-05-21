using UnityEngine;

[CreateAssetMenu(fileName = "PaintBrush", menuName = "ScriptableObjects/Boosters/PaintBrush")]
public class PaintBrush : Boosters
{
	[SerializeField]
	private int itemId;

	[SerializeField]
	private PaintBrushViewConfig _configs;

	private BoosterPaintBrush _paintBrush;

	public override bool OnBoosterClick(BoosterViewInfo boosterViewInfo)
	{
		return false;
	}

	protected override BoosterActivationDataModel GetBoosterActivationDataModel()
	{
		return default(BoosterActivationDataModel);
	}

	public override void OnBoosterClose()
	{
	}

	public override void BoosterExecuted()
	{
	}

	public override string GetDescription(int flowerId = 0)
	{
		return null;
	}

	public override string GetDetailedDescription(int flowerId = 0)
	{
		return null;
	}

	public override void OnShowBoosterProduction(Vector3 pos)
	{
	}
}
