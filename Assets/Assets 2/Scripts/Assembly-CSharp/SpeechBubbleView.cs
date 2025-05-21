using TMPro;
using UnityEngine;

public class SpeechBubbleView : MonoBehaviour
{
	[SerializeField]
	private RectTransform _bubbleObject;

	[SerializeField]
	private TextMeshProUGUI _text;

	private Vector2 _sizeOfTutorial;

	private void Awake()
	{
	}

	public void SetState(bool state, float delay = 0.5f)
	{
	}

	public void UpdateText(string text)
	{
	}

	public void ResetView()
	{
	}
}
