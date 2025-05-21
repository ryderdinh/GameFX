using MS.Casual.Market;
using UnityEngine;

public class MainMenuLiveOpsView : MonoBehaviour
{
	public MainMenuSPPController SppViewController;

	[Header("Mission Center")]
	public MissionSystemController MissionSystemController;

	public MissionCenterButtonView MissionCenterButton;

	public MissionCenterTutorialMask MissionCenterTutorialMask;

	[Header("LiveOpsOffer Button")]
	public LiveOpsOfferButtonView LiveOpsOfferButton;

	[SerializeField]
	private ParticleSystem _missionTrail;

	[SerializeField]
	private ParticleSystem _sppTrail;

	[SerializeField]
	private ParticleSystem _liveOpsOfferTrail;

	private Vector3 _defaultMissionPosition;

	private Vector3 _defaultBloomPassPosition;

	private Vector3 _defaultLiveOpsOfferPosition;

	public void InitializeLiveOps()
	{
	}

	public void Initialize()
	{
	}

	public void RegisterEvents()
	{
	}

	public void UnRegisterEvents()
	{
	}

	public void Show(MainMenuType mainMenuType)
	{
	}

	private void ShowMissionCenterTutorial(MainMenuType mainMenuType)
	{
	}

	public void Hide()
	{
	}

	public void PlayFlowerParticles(float delay, MainMenuType mainMenuType)
	{
	}

	private void OnAllLiveOpsOffersPurchased()
	{
	}

	public void LiveOpsIconsAnimationOnIntro(HudEventIntroAnimationData hudEventIntroAnimationData)
	{
	}

	private void LiveOpsIconMoveAnimation(Transform icon, Vector3 startPosition, Vector3 startHandle, Vector3 targetPositon, Vector3 targetHandle, ParticleSystem particles, float initialDelay = 1.5f)
	{
	}

	private void SetParticlesState(bool state)
	{
	}
}
