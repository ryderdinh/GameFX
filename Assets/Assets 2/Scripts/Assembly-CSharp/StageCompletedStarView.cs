using DG.Tweening;
using TMPro;
using UnityEngine;

public class StageCompletedStarView : MonoBehaviour
{
	[SerializeField]
	private LevelSystem _levelSystem;

	[SerializeField]
	private Transform _starTransform;

	[SerializeField]
	private Transform _starTargetTransform;

	[SerializeField]
	private Transform _starEndTransform;

	[SerializeField]
	private Transform _starsContainerTransform;

	[SerializeField]
	private TextMeshProUGUI _starsTextBg;

	[SerializeField]
	private TextMeshProUGUI _starsText;

	[SerializeField]
	private ParticleSystem _starsParticle;

	private Vector3 _starDefaultPosition;

	private Vector3 _starDefaultScale;

	private Vector3 _starContainerDefaultPosition;

	private Vector3 _starMovePosition;

	private Sequence _starSequence;

	public void Initialize()
	{
	}

	public void Show()
	{
	}

	private void PlayStarTween(int currentStars, int totalStars)
	{
	}

	private void ResetStar()
	{
	}

	private void UpdateStarsText(int currentStars, int totalStars)
	{
	}

	private void PlayStarsParticle()
	{
	}

	private void MoveStarContainer(bool moveIn)
	{
	}

	private void ForceMoveStarContainer(bool moveIn)
	{
	}

	private void SetStarState(bool state)
	{
	}
}
