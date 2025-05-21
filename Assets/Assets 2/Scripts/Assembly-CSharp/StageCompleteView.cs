using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StageCompleteView : MonoBehaviour
{
	[SerializeField]
	private GameObject _stageContainer;

	[SerializeField]
	private TextMeshProUGUI _levelText;

	[SerializeField]
	private TextMeshProUGUI _levelBGText;

	[SerializeField]
	private TextMeshProUGUI _iconToMovelevelText;

	[SerializeField]
	private TextMeshProUGUI _iconToMovelevelBGText;

	[SerializeField]
	private Image _appreciationImage;

	[SerializeField]
	private GameObject _itemToMoveObj;

	[SerializeField]
	private Transform _itemToMoveTransform;

	[SerializeField]
	private Image _stageBgToMove;

	[SerializeField]
	private Transform _targetPoint;

	[SerializeField]
	private StageCompletedStarView _starCollectableView;

	[SerializeField]
	private ParticleSystem _impactParticles;

	private Vector3 _defaultIconPosition;

	private Vector3 _defaultIconScale;

	private Sequence _stageIconSequence;

	public void Initialize()
	{
	}

	public void Show(int level)
	{
	}

	private void UpdateAppreciationImage()
	{
	}

	private void SetBannerState(bool state)
	{
	}

	private void UpdateLevel(int level)
	{
	}

	private void MoveStageIcon()
	{
	}

	private void ResetIconToMove()
	{
	}

	private void PlayImpactParticles()
	{
	}

	private void SetItemToMoveState(bool state)
	{
	}
}
