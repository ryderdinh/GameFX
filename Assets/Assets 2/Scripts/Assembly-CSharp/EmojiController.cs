using DG.Tweening;
using UnityEngine;

public class EmojiController : MonoBehaviour
{
	private static int HeartKey;

	private static int AngryKey;

	[SerializeField]
	private Animator _emojiAnimator;

	[SerializeField]
	private Transform _emojiTransform;

	[SerializeField]
	private SpriteRenderer _emojiRenderer;

	private Vector3 _emojiDefaultPosition;

	private Sequence _emojiSequence;

	public void Initialize()
	{
	}

	public void PlayEmojiSequence(int id)
	{
	}

	private void ResetEmoji()
	{
	}

	private void SetEmojiState(bool state)
	{
	}

	private void PlayEmojiAmimation(int id)
	{
	}
}
