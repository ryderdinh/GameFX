using UnityEngine;

[CreateAssetMenu(fileName = "ProgressionSystem", menuName = "ScriptableObjects/ProgressionSystem")]
public class ProgressionSystem : ScriptableObject
{
	public MatchesSystem MatchesSystem;

	public ScoreSystem ScoreSystem;

	public ItemSystem ItemSystem;

	public ExperienceSystem ExperienceSystem;

	public CashObject CashSystem;

	public LevelSystem LevelSystem;

	public SkipAdsObject SkipAdsSystem;

	[SerializeField]
	private MetaSystem _metaSystem;

	private Camera _worldCamera;

	private StreakSystemObject _streakSystem;

	private Camera _uiCamera;

	private void RegisterEvents()
	{
	}

	public void UnregisterEvents()
	{
	}

	public void Initialize()
	{
	}

	public void LoadGame()
	{
	}

	public void MatchMade(int mergedItemID, int streakCount, FlowerType flowerType, float scorePercentage = 1f, bool isBoosterMerge = false, bool isTurboMode = false)
	{
	}

	private void UpdateProgressState(int mergedItemId, int streakCount, float scorePercentage, bool isBoosterMerge = false, bool isTurboMode = false)
	{
	}

	public void UpdateProgressView(int mergedItemId, int streakCount, Vector3 slotPosition, bool isComboMove = false, float scorePercentage = 1f, float animationStartDelay = 1.75f, bool isBoosterMerge = false, bool isTurboMode = false)
	{
	}

	public void ProgressMade(int mergedItemID, int streakCount, Vector3 slotPosition)
	{
	}

	public ProgressionModel LoadCurrentProgress()
	{
		return default(ProgressionModel);
	}

	public ExperienceModel LoadCurrentExperience()
	{
		return default(ExperienceModel);
	}

	public void ResetProgressOnLevelFail(bool resetView)
	{
	}

	public void ShowNextUnlockItemView()
	{
	}
}
