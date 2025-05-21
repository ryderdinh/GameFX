using UnityEngine;

public class LevelUpGiftSpawner : MonoBehaviour, ILevelUpGift
{
	[SerializeField]
	private LevelUpGift _giftBoxObject;

	[SerializeField]
	private GiftSpawnerSystem _giftSpawnerSystem;

	[SerializeField]
	private Transform _startPosition;

	[SerializeField]
	private float _moveTime;

	[SerializeField]
	private AnimationCurve _giftDropCurve;

	private bool _giftSpawned;

	private IGridHandler _gridHandler;

	private Vector3 _dropPosition;

	private LevelUpData _levelupData;

	public void Initialize(IGridHandler gridHandler)
	{
	}

	private void RegisterEvents()
	{
	}

	private bool IsGiftSpawned()
	{
		return false;
	}

	private void LevelUp(LevelUpData levelUpData)
	{
	}

	private void Reset()
	{
	}

	void ILevelUpGift.OpenGift()
	{
	}
}
