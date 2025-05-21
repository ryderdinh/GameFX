using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Analytics;
using DB;
using MS.Casual.PieceSort;
using UnityEngine;

public class GridController : MonoBehaviour, ITrayHandler, ISlotsDatabase, ISlot, IGridBooster, IBoostersTutorial, IGridPrePopulation
{
	[CompilerGenerated]
	private sealed class _003CMovementAnimationCR_003Ed__64 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public GridController _003C_003E4__this;

		public bool isTurboMode;

		private List<Slot> _003Clist_003E5__2;

		private int _003ClastItemId_003E5__3;

		private List<MovementData> _003Cmoves_003E5__4;

		private bool _003CisCombo_003E5__5;

		private int _003Cvalue_003E5__6;

		private bool _003CcanPlaceTrays_003E5__7;

		private int _003CcomboIndex_003E5__8;

		private int _003Ci_003E5__9;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CMovementAnimationCR_003Ed__64(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[SerializeField]
	private List<Slot> _slots;

	[SerializeField]
	private SlotsStateObject _slotsStateObject;

	[SerializeField]
	private DBString _dbSlotsState;

	[SerializeField]
	private TutorialController _tutorialController;

	[SerializeField]
	private Bool _isTutorialActive;

	[SerializeField]
	private Camera _mainCamera;

	[SerializeField]
	private GridDifficultyCalculator _gridDifficultyCalculator;

	[SerializeField]
	private AllItemsObject _allItemsObject;

	[SerializeField]
	private UserJourneySystem _userJourneySystem;

	[SerializeField]
	private TurboModeSystem _turboModeSystem;

	[SerializeField]
	private Transform _flowerParticlesContainer;

	[SerializeField]
	private AnalyticsSystem _analyticsSystem;

	private Appreciation _appreciation;

	private GridSort _gridSort;

	private int _rows;

	private int _columns;

	private float _xOffset;

	private float _zOffset;

	private Neighbours _neighbours;

	private DishSpawnerObject _dishSpawner;

	private readonly List<int> _hightlightInProgress;

	private readonly Queue<List<MovementData>> _movesQueue;

	private readonly List<List<int>> _bunchedMoves;

	private readonly List<int> _slotsFullList;

	private readonly List<int> _tilesToSnapOn;

	private readonly GridSnapData _gridSnapData;

	private readonly List<Dish> _spawnerDishes;

	private WaitForSeconds _movementAnimationWait;

	private WaitForSeconds _sameSliceMovementWait;

	private WaitForSeconds _gridSnapWait;

	private WaitForSeconds _comboWait;

	private ProgressionSystem _progression;

	private StreakSystemObject _streakSystem;

	private Coroutine _movementAnimationCR;

	private IGridHandler _gridHandler;

	private IBoing _boingHandler;

	private bool _isFirstLaunch;

	private GridConfig _gridConfigs;

	private Vector3 _slotPosition;

	private GridBoostersController _gridBoostersController;

	private Camera _worldCamera;

	private Dish _sexyPot;

	private bool _butterflyTutorialActive;

	public int MovingSlotID => 0;

	public void SetButterflyTutorialActiveState(bool state)
	{
	}

	public void Initialize(IGridHandler gridHandler, IBoing boingHandler)
	{
	}

	public bool StartGame()
	{
		return false;
	}

	public void ResetGridData()
	{
	}

	public void ResetGrid()
	{
	}

	private void InitializeSlots()
	{
	}

	private void RegisterEvents()
	{
	}

	public void MoveSlot()
	{
	}

	public float CompleteAllSlots()
	{
		return 0f;
	}

	private int GetIndex(int x, int y)
	{
		return 0;
	}

	private List<int> CalculateSlotIndexes(List<Dish> dishes)
	{
		return null;
	}

	private void SetDishesState(bool state)
	{
	}

	private bool IsOnGrid(Vector3 position)
	{
		return false;
	}

	private void SnapOnGrid(bool sort, bool turboMode = false)
	{
	}

	private bool SortGrid(List<int> indexes, bool isSafeCheck = false, bool isTurboMode = false)
	{
		return false;
	}

	private void UpdateGridStateWithMoves(List<MovementData> moves, bool impactStreak, bool isSafeCheck = false, bool isTurboMode = false)
	{
	}

	private void PlayMovementAnimationCR(bool isTurboMode)
	{
	}

	private void StopMovementAnimationCR()
	{
	}

	private void MovementAnimationCompleted()
	{
	}

	[IteratorStateMachine(typeof(_003CMovementAnimationCR_003Ed__64))]
	private IEnumerator MovementAnimationCR(bool isTurboMode)
	{
		return null;
	}

	private bool IsActingAsBridge(int i, int index, List<MovementData> moves)
	{
		return false;
	}

	private bool IsActingAsBridge(int i, int j, int index, List<MovementData> moves)
	{
		return false;
	}

	private void BunchGridMoves(List<MovementData> moves)
	{
	}

	private void UnhighlightPreviousTiles()
	{
	}

	private void HighlightTiles(List<int> indexes, bool isBooster)
	{
	}

	private bool IsValidateIndex(List<int> indexes)
	{
		return false;
	}

	void ISlotsDatabase.SaveGridState()
	{
	}

	private void SaveGridData()
	{
	}

	private void UpdateSlotsData()
	{
	}

	void IGridPrePopulation.PreLoadSlot(GridPrePopulationData data)
	{
	}

	private bool LoadSlots()
	{
		return false;
	}

	private void ResetSlotsData()
	{
	}

	private void ReplaceAndSortGrid(bool sort)
	{
	}

	public int SafeCheckGrid()
	{
		return 0;
	}

	void ITrayHandler.SafeCheckGrid()
	{
	}

	void ITrayHandler.TrayIsMoving(Tray tray)
	{
	}

	bool ITrayHandler.CanPlaceTraysOnGrid(List<Tray> trays, bool isStart = false)
	{
		return false;
	}

	int ITrayHandler.AvailableSlots()
	{
		return 0;
	}

	bool ITrayHandler.AllSlotsOccupied()
	{
		return false;
	}

	bool ITrayHandler.CanPlaceDualTray(Tray tray)
	{
		return false;
	}

	bool ITrayHandler.CanPlaceTray(TrayType trayType)
	{
		return false;
	}

	bool ITrayHandler.SnapTrayOnGrid(Vector2 touchPosition, Tray tray)
	{
		return false;
	}

	void ITrayHandler.UnhighlightPreviousTiles()
	{
	}

	ArrayArrayInt ITrayHandler.GetState()
	{
		return null;
	}

	private void ShowTutorial(Vector3 position)
	{
	}

	private Vector3 GetTutorialFirstSlotPosition()
	{
		return default(Vector3);
	}

	private Vector3 GetTutorialAdjacentSlotPosition()
	{
		return default(Vector3);
	}

	private void WobbleDishesOnFail()
	{
	}

	void ISlot.SlotDrag(Slot slot)
	{
	}

	void ISlot.SlotClicked(Slot slot)
	{
	}

	void ISlot.EmptySlotClicked(Slot slot)
	{
	}

	void ISlot.SetMovingSlot(int id)
	{
	}

	bool ISlot.SnapSlotOnGrid(bool canSnap)
	{
		return false;
	}

	int ISlot.MovingSlotID()
	{
		return 0;
	}

	public void ApplyPitchFork()
	{
	}

	public void ApplyColumnSort()
	{
	}

	public void ApplyRowSort()
	{
	}

	public void ApplyMagicPot(int cakeID)
	{
	}

	public void ApplySuperMagicPot(int cakeID)
	{
	}

	public void ApplyWheelBarrow()
	{
	}

	private void ApplyFlowerTierUpgrade(int flowerId)
	{
	}

	public void AddFlowerTierUpdateCards(int flowerID, int cardsCount)
	{
	}

	private bool ApplyFlowerTierUpdate(int flowerId)
	{
		return false;
	}

	public bool ApplyDishTierUpdate()
	{
		return false;
	}

	public void SetWaterCanProgress(bool status)
	{
	}

	public void SetSuperWaterCanProgress(bool status)
	{
	}

	public void SetSwapSlotsProgress(bool status)
	{
	}

	public bool ApplyTurboMode(bool activate)
	{
		return false;
	}

	public void SetHorizontalRocketProgress(bool status)
	{
	}

	public void SetVerticalRocketProgress(bool status)
	{
	}

	public void SetHorizontalVerticalRocketProgress(bool status)
	{
	}

	public void SetBombProgress(bool status)
	{
	}

	public Slot GetRandomSlot(SlotState slotState)
	{
		return null;
	}

	public void SetTrovelProgress(bool status)
	{
	}

	public void SetPaintBrushProgress(bool status, int cakeID = -1)
	{
	}

	public void SetSlotUnlockBoosterProgress(bool status)
	{
	}

	public void SetSexyPotBoosterProgress(bool status)
	{
	}

	void IGridBooster.WaterCanApplied()
	{
	}

	void IGridBooster.SuperWaterCanApplied()
	{
	}

	void IGridBooster.HorizontalRocketApplied()
	{
	}

	void IGridBooster.VerticalRocketApplied()
	{
	}

	void IGridBooster.HorizontalVerticalRocketApplied()
	{
	}

	void IGridBooster.BombApplied(float delay)
	{
	}

	void IGridBooster.RowSortApplied()
	{
	}

	void IGridBooster.ColumnSortApplied()
	{
	}

	void IGridBooster.TrovelApplied()
	{
	}

	void IGridBooster.PaintBrushApplied(Slot slot)
	{
	}

	void IGridBooster.PitchForkApplied()
	{
	}

	void IGridBooster.MagicPotApplied()
	{
	}

	void IGridBooster.SuperMagicPotApplied()
	{
	}

	void IGridBooster.CustomSortGrid(List<MovementData> moves, bool isSafeCheck)
	{
	}

	private void BoosterApplied(float delay)
	{
	}

	void IGridBooster.MoveSlot(List<Dish> dishes)
	{
	}

	void IGridBooster.UnhighlightPreviousTiles()
	{
	}

	void IGridBooster.ReplaceAndSortGrid(List<int> indexes, List<Dish> dishes)
	{
	}

	void IGridBooster.SlotUnlockApplied(int id)
	{
	}

	List<int> IGridBooster.CalculateSlotIndexes(List<Dish> dishes)
	{
		return null;
	}

	void IGridBooster.SwapSlotCompleted()
	{
	}

	public int GetGridDifficulty()
	{
		return 0;
	}

	void IGridBooster.WheelBarrowExecuted(float time)
	{
	}

	void IGridBooster.SaveGridData()
	{
	}

	void IGridBooster.SexyPotApplied()
	{
	}

	Vector3 IBoostersTutorial.GetPositionAgainstSlotID(int id)
	{
		return default(Vector3);
	}

	Vector3 IBoostersTutorial.GetPositionAgainstTrayID(int id)
	{
		return default(Vector3);
	}

	TutorialController IBoostersTutorial.GetTutorialController()
	{
		return null;
	}

	private bool IsBoardEmpty()
	{
		return false;
	}

	private bool IsBoardFull()
	{
		return false;
	}
}
