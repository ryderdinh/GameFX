using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public abstract class SingleMissionObjectView : MonoBehaviour
{
	[SerializeField]
	[Header("MissionInfo")]
	private TextMeshProUGUI _descriptionText;

	[SerializeField]
	private Image _missionIcon;

	[SerializeField]
	private Vector3 _descriptionTextPos;

	[SerializeField]
	[Header("Reward")]
	private TextMeshProUGUI _rewardAmountText;

	[SerializeField]
	private TextMeshProUGUI _rewardText;

	[SerializeField]
	private GameObject _rewardObj;

	[SerializeField]
	private GameObject _rewardImageAndAmountObject;

	[SerializeField]
	private GameObject _rewardIconObj;

	[SerializeField]
	private Image _rewardIconImage;

	[SerializeField]
	private CanvasGroup _rewardCanvasGroup;

	[Header("Progress")]
	[SerializeField]
	private TextMeshProUGUI _progressText;

	[SerializeField]
	private GameObject _completedState;

	[SerializeField]
	private GameObject _progressState;

	[SerializeField]
	private Image _progressBarImage;

	[SerializeField]
	private Image _progressInnerGloweImage;

	[SerializeField]
	private GameObject _particlesObj;

	[SerializeField]
	private ParticleSystem _sparkleParticles;

	[SerializeField]
	private ParticleSystem _flareParticles;

	[SerializeField]
	private CanvasGroup _progressCanvas;

	[SerializeField]
	[Header("CompletedRow")]
	private Image _greenRowImage;

	[SerializeField]
	private Image _taskCompletedImage;

	[SerializeField]
	protected Button _claimButton;

	[SerializeField]
	private Vector3 _targetPosition;

	[SerializeField]
	private CanvasGroup _completedRowCanvasGroup;

	[Header("Claimed")]
	[SerializeField]
	private GameObject _claimedObj;

	[SerializeField]
	private GameObject _claimedImageObj;

	[SerializeField]
	private GameObject _claimedTextObj;

	private Vector3 _descriptionDefaultTextPos;

	private Vector3 _rewardImageDefaultPosition;

	private Vector3 _particleDefaultPosition;

	private Vector3 _claimButtonDefaultScale;

	protected SingleMissionController _SingleMissionController;

	private RewardObject _reward;

	protected int _id;

	private float _initialDelay;

	private Sequence _animateMissionRowSequence;

	private Sequence _animateMissionClaimedRowSequence;

	private Sequence _animateMissionCompletedRowSequence;

	public bool IsClaimed => false;

	public MissionType type => default(MissionType);

	public virtual void Initialize(SingleMissionController singleMissionController, int id)
	{
	}

	protected virtual void RegisterEvents()
	{
	}

	public virtual void CollectingReward()
	{
	}

	private void ActivateClaimedProgressBarState()
	{
	}

	public void Show(float delay)
	{
	}

	private void AnimateMissionRow(int speed)
	{
	}

	public bool IsMissionCompleted()
	{
		return false;
	}

	private void ClaimedState()
	{
	}

	private void MissionCompleted(float speed)
	{
	}

	private void UpdateProgressText(float x)
	{
	}

	private void TaskCompletedState(bool state)
	{
	}

	private void PlayButtonImpact()
	{
	}
}
