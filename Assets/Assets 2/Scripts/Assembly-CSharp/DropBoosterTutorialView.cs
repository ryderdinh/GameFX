using UnityEngine;

public class DropBoosterTutorialView : BoostersTutorialViewController
{
	[SerializeField]
	private RectTransform BackgroundSoftMaskTransform;

	[SerializeField]
	private Transform BackgroundSoftMaskFrameTransform;

	protected override void InitializeEvents()
	{
	}

	protected override void BoostersTapTutorial(Vector3 screenPoint)
	{
	}
}
