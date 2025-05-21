using DB;
using DG.Tweening;
using UnityEngine;

public class TutorialController : MonoBehaviour
{
	[SerializeField]
	private LineRenderer _lineRenderer;

	[SerializeField]
	private Transform _hand;

	[SerializeField]
	private SpriteRenderer _handRenderer;

	[SerializeField]
	private Transform _arrow;

	[SerializeField]
	private Bool _isTutorialActive;

	[SerializeField]
	private DBInt _dbTutorialShowCount;

	[SerializeField]
	private DBInt _dbtutorialMoves;

	[SerializeField]
	private Bool _isBoostersTutorialActive;

	private LineController _lineController;

	private Sequence _handSequence;

	private int _tutorialMoves;

	private int _tutorialShowCount;

	public int TutorialShownCount => 0;

	public int TutorialMoves => 0;

	public void Initialize()
	{
	}

	public void DrawLine(Vector3 startPoint, Vector3 targetPoint)
	{
	}

	public void EraseLine()
	{
	}

	private void SetTutorialState(bool state)
	{
	}

	public void TutorialShown()
	{
	}

	public void TutorialMoveMade()
	{
	}

	public void ResetTutorialMoves()
	{
	}

	private void SetArrowState(bool state)
	{
	}

	private void SetHandState(bool state)
	{
	}
}
