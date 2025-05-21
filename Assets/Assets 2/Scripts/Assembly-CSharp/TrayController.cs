using System.Collections.Generic;
using UnityEngine;

public class TrayController : MonoBehaviour, ITray, IGridHandler, ITrayBooster
{
	[SerializeField]
	private Transform _trayContainer;

	[SerializeField]
	private Camera _mainCamera;

	[SerializeField]
	private LevelSystem _levelSystem;

	[SerializeField]
	private PowerUpsSystem _powerUpsSystem;

	private ITrayHandler _inputGridSystem;

	private ISlotsDatabase _dbSlots;

	private IBoing _boingHandler;

	private int _movingTrayID;

	private Vector3 _targetPosition;

	private LayerMask _layerMask;

	private DishConfig _dishConfigs;

	private readonly RaycastHit[] _raycastResults;

	private List<Tray> _trays;

	private TraySpawnerObject _traySpawnerObject;

	private bool _checkForValidMove;

	private int _dishVanishCount;

	private TrayBoostersController _trayBoostersController;

	private bool _traysMovingState;

	private bool _IsTraySpawningPaused;

	private ShearProduction _shearProduction;

	public int MovingTrayID => 0;

	public void Initialize(ITrayHandler inputGridSystem, ISlotsDatabase dbSlots, IBoing boingHandler)
	{
	}

	public void StartGame()
	{
	}

	public void ResetTraysData()
	{
	}

	public void ResetTrays()
	{
	}

	private void InitializeEvents()
	{
	}

	private void SetTrayState(bool state)
	{
	}

	public void MoveTray()
	{
	}

	private void MoveBoingCollider(Vector3 position)
	{
	}

	private void SetTraysPosition()
	{
	}

	private int CalculateNumberOfHorizontalTrays()
	{
		return 0;
	}

	private float CalculateOffsetBetweenTrays(int horizontalTrays)
	{
		return 0f;
	}

	private bool IsTrayAvailable()
	{
		return false;
	}

	private bool RespawnTrays()
	{
		return false;
	}

	public void RespawningTraysBooster()
	{
	}

	public void ActivateTrayFavors()
	{
	}

	private void RefreshTrays()
	{
	}

	private void RespawningTrays()
	{
	}

	public bool IsValidMoveLeft(bool isStart = false, bool safeCheck = true)
	{
		return false;
	}

	private void SpawnAndValidate()
	{
	}

	private void TraySnappingComplete()
	{
	}

	void ITray.SetMovingTray(int id)
	{
	}

	void ITray.ResetMovingTray()
	{
	}

	bool ITray.SnapTrayOnGrid()
	{
		return false;
	}

	void IGridHandler.GridSortingCompleted()
	{
	}

	void IGridHandler.BoosterAppliedOnGrid()
	{
	}

	void IGridHandler.GridStateNotUpdated()
	{
	}

	Vector3 IGridHandler.GetTutorialTrayPosition()
	{
		return default(Vector3);
	}

	Vector3 IGridHandler.GetEmptySlotPosition()
	{
		return default(Vector3);
	}

	List<Tray> IGridHandler.GetTrays()
	{
		return null;
	}

	public void SetSmallFertilizerProgress(bool status)
	{
	}

	void ITray.TrayClicked(Tray tray)
	{
	}

	void ITrayBooster.SmallFertilizerApplied(Tray tray)
	{
	}

	void ITrayBooster.LargeFertilizerApplied()
	{
	}

	void ITrayBooster.TierUpdateApplied()
	{
	}

	private void ApplyFlowerTierUpdate(int flowerId)
	{
	}

	public bool ApplyFlowerTierUpdate(int flowerId, float delay)
	{
		return false;
	}

	public bool ApplyDishTierUpdate()
	{
		return false;
	}

	public bool ApplyTurboMode(bool activate)
	{
		return false;
	}

	public void ApplyLargeFertilizer()
	{
	}

	private void MoveTraysToGridBoosterState()
	{
	}

	private void MoveTraysToBoosterState()
	{
	}

	private void MoveTraysToNormalState(float duration)
	{
	}

	private void MoveTraysToNormalState()
	{
	}

	void ITrayBooster.RespawnBoosterApplied()
	{
	}

	bool IGridHandler.IsValidMoveLeft()
	{
		return false;
	}

	public void ForceTrayBackInPlace()
	{
	}

	public void ForceCompleteTrays()
	{
	}

	private int GetAvailableTraysCount()
	{
		return 0;
	}

	private void ForceTrayBackInPlaceOnOfferEvent()
	{
	}

	private void ForceTrayBackInPlaceLevelUpEvent(LevelUpData levelUpData)
	{
	}

	public void SetTraysMovingState(bool state)
	{
	}

	private void OnForceTrayBlockerOn()
	{
	}

	private void PauseTraySpawning()
	{
	}

	private void ResumeTraySpawning()
	{
	}

	private void ResumeTraysRespawning()
	{
	}

	private void ShopCompleted()
	{
	}

	public TrayType GetDualTrayType()
	{
		return default(TrayType);
	}
}
