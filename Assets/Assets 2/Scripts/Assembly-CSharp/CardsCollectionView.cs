using System;
using System.Collections.Generic;
using MSKit.ResourcePool;
using MSKit.UIView;
using UnityEngine;

public class CardsCollectionView : BaseUIViewController<CardsCollectionViewRefs>
{
	private Vector3 _defaultButtonPosition;

	private Pool<CardReward> _cardsPool;

	private List<CardReward> _cards;

	private List<CardsToAddData> _cardsToAddData;

	private MarketCardsAnimationData _cardsToAnimateData;

	private bool _canAnimateAfterClaim;

	private Action _closeButtonCallback;

	public override void Initialize()
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

	public override void Show(object model = null)
	{
	}

	public void AddCards()
	{
	}

	private void CloseButtonClicked()
	{
	}

	public override void Hide()
	{
	}

	private void MoveInCloseButton()
	{
	}

	private void ForceMoveOutCloseButton()
	{
	}
}
