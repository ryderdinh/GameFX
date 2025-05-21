using System.Collections.Generic;
using UnityEngine;

public class ScoreView : MonoBehaviour
{
	[SerializeField]
	private ScoreViewRefs ScoreViewRefs;

	private List<ScoreViewItemRefs> _itemsPool;

	private int _underlayColorId;

	public void Initialize()
	{
	}

	public void RegisterEvents()
	{
	}

	public void UnregisterEvents()
	{
	}

	private void AddScoreAnimation(CollectablesData data)
	{
	}

	public void AddScoreAnimation(Vector3 position, float startDelay, float scoreCount, FlowerType flowerType)
	{
	}

	private void AddScoreAnimation(Vector3 startPosition, float startDelay, float scoreCount, int itemId, bool isExtraBonus, bool calculateScreenPoint, bool isTurboMode = false)
	{
	}

	private void ResetScores(ScoreViewItemRefs scoreViewItemRefs, Color glowColor, Vector3 screenPoint)
	{
	}
}
