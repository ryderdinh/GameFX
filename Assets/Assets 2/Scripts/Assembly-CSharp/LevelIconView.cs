using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class LevelIconView : MonoBehaviour
{
	[SerializeField]
	private Image _levelImage;

	[SerializeField]
	private Transform _levelIconTransform;

	[SerializeField]
	private TextMeshProUGUI _levelText;

	[SerializeField]
	private GameObject _flagIcon;

	[SerializeField]
	private GameObject _crownIcon;

	private int _currentLevel;

	private Vector3 _levelIconDefaultScale;

	private Sequence _levelCompleteSequence;

	public void Initialize()
	{
	}

	public void Show(int level, ProgressLevelType type, bool levelCompleted = false)
	{
	}

	private void LevelComplete()
	{
	}

	private void UpdateText(int level)
	{
	}

	private void SetFlagState(bool state)
	{
	}

	private void SetCrownState(bool state)
	{
	}
}
