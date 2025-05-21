using MSKit.UIView;
using UnityEngine;
using UnityEngine.UI;

public class MetaMenuViewRefs : BaseUIViewRefs
{
	public Transform CurrencyContainer;

	public MetaController MetaController;

	public Button BackButton;

	public Button LeftScrollButton;

	public Button RightScrollButton;

	public GameObject GodRaysObj;

	[Header("Meta Menu")]
	public Transform BackBtnTransform;

	public Transform LeftBtnTransform;

	public Transform RightBtnTransform;

	[Header("World Complete")]
	public ParticleSystem WorldCompleteParticles;

	public Transform CompleteTextTransform;
}
