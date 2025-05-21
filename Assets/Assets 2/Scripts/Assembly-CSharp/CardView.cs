using DG.Tweening;
using MSKit.ResourcePool;
using UnityEngine;

public class CardView : MonoBehaviour
{
	[SerializeField]
	private Transform _cardsContainer;

	[SerializeField]
	private Transform _cardsPoolContainer;

	[SerializeField]
	private Card _card;

	[SerializeField]
	private Transform _startPointTransform;

	[SerializeField]
	private ParticleSystem _cardParticle;

	[SerializeField]
	private ItemUpgradeSystem _itemUpgradeSystem;

	[SerializeField]
	private ItemUpgradeMenuButtonNotification _itemUpgradeMenuButtonNotification;

	private Vector3 _defaultPosition;

	private Vector3 _defaultScale;

	private Vector3 _startPosition;

	private Sequence _cardContainerSequence;

	private Pool<Card> _cardPool;

	public Transform ContainerTransform => null;

	public void Initialize()
	{
	}

	public void Show()
	{
	}

	private void RegisterEvents()
	{
	}

	private void AnimateCardOnCollection(CollectablesData data)
	{
	}

	private void PlayCardContainerSequence()
	{
	}
}
