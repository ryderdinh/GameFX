using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class ViewAnimationController
{
	private Image _overlay;

	private RectTransform _container;

	private Vector3 _localScale;

	private float _overLayAlpha;

	private Sequence _moveInSequence;

	private Sequence _moveOutSequence;

	public ViewAnimationController(RectTransform rect, Image img)
	{
	}

	public void MoveIn(Vector3 startScale, float scaleDuration = 0.3f, float fadeDuration = 0.15f, float delay = 0f, Ease ease = Ease.OutBack)
	{
	}

	public void MoveInAndFade(CanvasGroup canvasGroup, Vector3 startScale, float duration = 0.3f, Ease ease = Ease.OutBack, float delay = 0f)
	{
	}

	public void MoveOut(TweenCallback callback, Vector3 endScale, float fadeDuration = 0.1f, float scaleDuration = 0.2f, Ease ease = Ease.InBack, float delay = 0f)
	{
	}

	public void SlideIn(Vector3 startPos, float duration = 0.3f, Ease ease = Ease.OutBack, float delay = 0f, bool fromLeft = false)
	{
	}

	public void SlideOut(TweenCallback callback, float duration = 0.15f, Ease ease = Ease.InBack, float delay = 0f, bool fromLeft = false)
	{
	}

	public void SlideUp(Vector3 startPos, float duration = 0.3f, Ease ease = Ease.OutBack, float delay = 0f, bool fromLeft = false)
	{
	}

	public void SlideDown(TweenCallback callback, float duration = 0.15f, Ease ease = Ease.InBack, float delay = 0f, bool fromLeft = false)
	{
	}
}
