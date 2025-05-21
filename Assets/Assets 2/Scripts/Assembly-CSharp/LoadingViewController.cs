using DG.Tweening;
using MSKit.UIView;
using UnityEngine;

public class LoadingViewController : BaseUIViewController<LoadingViewRefs>
{
	[SerializeField]
	private bool _isTransitionScreen;

	private Vector3 _leftInitialPos;

	private Vector3 _rightInitialPos;

	private Sequence _panelSequence;

	public override void Initialize()
	{
	}

	public override void Show(object model = null)
	{
	}

	public override void InitializeButtons()
	{
	}

	public override void InitializeTexts()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	public void PanelSequence()
	{
	}

	public void UpdateFillText(float value)
	{
	}

	private void ResetView()
	{
	}

	private void SetPanelState(bool state)
	{
	}
}
