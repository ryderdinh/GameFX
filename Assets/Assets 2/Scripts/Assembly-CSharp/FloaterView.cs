using DG.Tweening;
using MSKit.UIView;
using TMPro;
using UnityEngine;

public class FloaterView : BaseUIViewController<FloaterViewRefs>
{
	[SerializeField]
	private TextMeshProUGUI _floater;

	[SerializeField]
	private RectTransform _floaterContainer;

	[SerializeField]
	private CanvasGroup _floaterCanvasGroup;

	private Vector3 _position;

	private Sequence _floaterSequence;

	public new void Initialize()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void InitializeButtons()
	{
	}

	private void ResetFloater(Vector2 initPos)
	{
	}

	private void ShowFloater(FloaterText floater)
	{
	}

	private void ShowCustomFloater(CustomFloaterText customFloater)
	{
	}

	private void TweenFloater(Vector2 startPos, float yOffset = 200f)
	{
	}
}
