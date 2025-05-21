using UnityEngine;
using UnityEngine.EventSystems;

public class ButterflyView : MonoBehaviour, IPointerDownHandler, IEventSystemHandler
{
	public GameObject ButterflyContainer;

	public Animator ButterflyAnimatorController;

	public GameObject TrailParticle;

	public ParticleSystem CompletionParticle;

	public Material ButterflyMaterial;

	private IBoosterProviderClick _boosterProviderClickHandler;

	public void Initialize(IBoosterProviderClick boosterProviderClick)
	{
	}

	void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
	{
	}
}
