using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "MatchesSystem", menuName = "ScriptableObjects/ProgressionSystem/MatchesSystem")]
public class MatchesSystem : ScriptableObject
{
	[SerializeField]
	private DBInt _dbMatchesCount;

	[SerializeField]
	private DBInt _dbLifeTimeMatchesCount;

	[SerializeField]
	private DBInt _dbMatchesCountForCardChest;

	private int _matchesCount;

	private int _matchesCountForView;

	private int _matchesCountForCardChest;

	private int _cacheMatches;

	private int _lifeTimeMatchesCount;

	public int MatchesCached => 0;

	public int MatchesCount => 0;

	public int MatchesCountForView => 0;

	public int MatchesCountForCardsChest => 0;

	public void Initialize()
	{
	}

	public void ResetMatches()
	{
	}

	public void ResetCardsChestMatches(int matchesUsed)
	{
	}

	public void MatchMade()
	{
	}

	public void MatchMadeForView()
	{
	}
}
