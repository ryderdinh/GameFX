using UnityEngine;

[CreateAssetMenu(fileName = "MetaScoreCalculcator", menuName = "ScriptableObjects/Meta/MetaScoreCalculcator")]
public class MetaScoreCalculcator : ScriptableObject
{
	[SerializeField]
	private ValueRange[] _metaScoreMultiplierRanges;

	[SerializeField]
	private MetaWorldConfig _metaWorldConfig;

	[SerializeField]
	private LevelSystem _levelSystem;

	public float GetMetaScoreMultiplier()
	{
		return 0f;
	}
}
