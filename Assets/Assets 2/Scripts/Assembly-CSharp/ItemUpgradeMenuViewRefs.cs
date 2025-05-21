using System.Collections.Generic;
using MSKit.UIView;
using UnityEngine;
using UnityEngine.UI;

public class ItemUpgradeMenuViewRefs : BaseUIViewRefs
{
	public ItemUpgradeView ItemUpgradeView;

	public ItemUpgradeSystem ItemUpgradeSystem;

	public ScoreView ScoreView;

	public Transform FlowerViewContainerTransform;

	public Transform ContainerTransform;

	public Transform ContentTransform;

	public Button CloseButton;

	public Button BackButton;

	public CanvasGroup Overlay;

	public List<RenderTexture> FlowerRenderTextures;

	public BaseTutorialMask FlowerUpgradeTutorialController;

	public Vector3 TutorialFrameScale;

	public CashView CashView;

	public float ContentPosition;

	[Header("Scroller")]
	public GridLayoutGroup GridLayoutGroup;

	public int ScrollPositionForGameplay;

	public int ScrollPositionForMainMenu;

	public ScrollRect Scroller;

	[Header("Market Button")]
	public Button MarketButton;

	[Header("Info")]
	public Button InfoButton;
}
