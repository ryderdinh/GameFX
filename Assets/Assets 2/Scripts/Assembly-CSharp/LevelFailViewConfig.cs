using UnityEngine;

[CreateAssetMenu(fileName = "LevelFailViewConfig", menuName = "Views/LevelFailViewConfig")]
public class LevelFailViewConfig : ScriptableObject
{
	[SerializeField]
	private string[] _levelEndTexts;

	[SerializeField]
	private string[] _levelCompleteTexts;

	public string GetLevelEndText()
	{
		return null;
	}

	public string GetLevelCompleteText()
	{
		return null;
	}
}
