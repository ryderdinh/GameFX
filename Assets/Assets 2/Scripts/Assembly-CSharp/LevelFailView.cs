using UnityEngine;

public class LevelFailView : LevelEndView<LevelFailViewRefs>, IReviveView
{
	private Vector3 _levelFailBannerInitialPosition;

	public override void Initialize()
	{
	}

	public override void Show(object model = null)
	{
	}

	private void ResetView()
	{
	}

	private void ShowFailScreen()
	{
	}

	public override void Hide()
	{
	}

	public override void RegisterEvents()
	{
	}

	public override void UnregisterEvents()
	{
	}

	private void HomeButtonClicked()
	{
	}

	public override void RetryButtonClicked()
	{
	}

	private void Retry()
	{
	}

	private void MoveOutSequence()
	{
	}

	private void MultiplyMatchesClicked(bool adWatched)
	{
	}

	private void GameOver()
	{
	}

	private void CloseButtonClicked()
	{
	}

	void IReviveView.HideReviveView()
	{
	}
}
