using DG.Tweening;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TurboModeToggle : MonoBehaviour
{
	[SerializeField]
	private RectTransform _container;

	[SerializeField]
	private TurboModeSystem _turboMode;

	[SerializeField]
	private RectTransform _uiHandleRectTransform;

	[SerializeField]
	private TextMeshProUGUI _onText;

	[SerializeField]
	private TextMeshProUGUI _offText;

	[SerializeField]
	private GameObject _activatedHeaderObj;

	[SerializeField]
	private RectTransform _activatedHeaderBar;

	[SerializeField]
	private RectTransform _activatedHeaderIconRect;

	[SerializeField]
	private TextMeshProUGUI _remainingMovesHeaderText;

	[SerializeField]
	private ParticleSystem _impactParticle;

	[SerializeField]
	private Image _turboImage;

	[SerializeField]
	private TextMeshProUGUI _scoreText;

	private Sequence _toggleSequence;

	private Vector2 _handlePosition;

	private Vector2 _turboHeaderContainerScale;

	private Vector2 _turboHeaderIconScale;

	private Vector3 _containerInitialPosition;

	public void Initialize()
	{
	}

	public void Show()
	{
	}

	public void Deactivated()
	{
	}

	public void Hide()
	{
	}

	public void ForceHide()
	{
	}

	public void ForceShow()
	{
	}

	public void Update()
	{
	}

	private void SwitchState(bool state)
	{
	}

	private void MoveVertically(RectTransform targetObj, Vector3 moveFrom, float moveDelta, float duration, Ease ease = Ease.InBack, float delay = 0f, TweenCallback onComplete = null)
	{
	}

	private void AnimateActiveHeader(bool state)
	{
	}
}
