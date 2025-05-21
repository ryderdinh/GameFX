using MSKit.UIView;
using TMPro;
using UnityEngine;

public class HighScoreViewRefs : BaseUIViewRefs
{
	public RectTransform Container;

	public GameObject ProgressObject;

	public GameObject CompletedObject;

	[Header("HighScore View")]
	public TextMeshProUGUI LabelText;

	public TextMeshProUGUI HighScoreText;

	public TextMeshProUGUI PreviousScoreText;

	public TextMeshProUGUI CompletedTextBG;

	public TextMeshProUGUI CompletedText;
}
