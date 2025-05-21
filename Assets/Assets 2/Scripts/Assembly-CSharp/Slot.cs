using System;
using System.Collections.Generic;
using DB;
using UnityEngine;
using UnityEngine.EventSystems;

public class Slot : MonoBehaviour, IPointerClickHandler, IEventSystemHandler, IPointerUpHandler, IPointerDownHandler, IBeginDragHandler, IDragHandler
{
	[SerializeField]
	private GameObject _highLightObj;

	[SerializeField]
	private SpriteRenderer _highLightSprite;

	[SerializeField]
	private SlotLockedState _lockedState;

	private Dish _dish;

	private SlotState _state;

	private int _slotId;

	private float _initialPositionY;

	private ArrayInt _slotData;

	private GridConfig _gridConfigs;

	private ISlot _iSlot;

	private Vector3 _initialSlotPosition;

	private bool _canSnap;

	public Dish Dish => null;

	public List<Flower> Cakes => null;

	public ArrayInt SlotData => null;

	public int SlotId => 0;

	public Transform Transform => null;

	public SlotState SlotState => default(SlotState);

	public void Initialize(int slodId, ArrayInt slotData, ISlot iSlot, bool isLocked)
	{
	}

	public bool IsSlotAvailable()
	{
		return false;
	}

	public bool IsSlotOccupied()
	{
		return false;
	}

	public bool IsSlotLocked()
	{
		return false;
	}

	public void ApplyWind(bool horizontal)
	{
	}

	public void ResetSlot()
	{
	}

	public void ResetSlotDish()
	{
	}

	public void FreeDish()
	{
	}

	public int ForceCompleteSlot(bool isCompleteWithDelay = true, bool isShopComplete = false, Action callback = null)
	{
		return 0;
	}

	public void PaintSlot(int cakeID)
	{
	}

	public void UpdateFlowerTier(int id)
	{
	}

	public bool ForceChangeCakes(int cakeID)
	{
		return false;
	}

	public void CompleteSlot()
	{
	}

	public void FillWithDish(Dish dish, bool AdjustDish = false, bool reset = true)
	{
	}

	public int GetAvailableIDCount(int id)
	{
		return 0;
	}

	public void HighlightSlot(bool highlightBooster = true)
	{
	}

	public void UnhighlightSlot()
	{
	}

	public void WobbleDish()
	{
	}

	public void CustomWobbleDish(float duration, float strength, int vibrato)
	{
	}

	public void ShearDish(List<Rigidbody> rb)
	{
	}

	public void WaterCanWobbleDish()
	{
	}

	public void WobbleDishOnFail()
	{
	}

	public Flower RemoveCakeFromDish(int id, bool sort = true)
	{
		return null;
	}

	public RemovingCakeDataModel GetCakesToRemove(int id, int count)
	{
		return null;
	}

	public int ForceRemoveCakes(int id, int count)
	{
		return 0;
	}

	public void ForceRemoveCakes(int id)
	{
	}

	public void SelfSortDish()
	{
	}

	public int CheckSlotStatus(int comboIndex = 0)
	{
		return 0;
	}

	private void ClearSlot(int comboIndex = 0)
	{
	}

	public void SetSlotToVacant()
	{
	}

	public void SetSlotToVacantandReset()
	{
	}

	public int GetUniqueItemsInDish()
	{
		return 0;
	}

	public void SetSlotLockState(bool isLocked)
	{
	}

	public void LockSelected()
	{
	}

	public void MarkSlotLockedByBooster()
	{
	}

	public void UnlockSlot()
	{
	}

	public void MoveLockedSlotToBreathingState()
	{
	}

	public void MoveLockedSlotToIdletate()
	{
	}

	private void SetHighLightState(float amount)
	{
	}

	void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
	{
	}

	void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
	{
	}

	void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
	{
	}

	public Vector3 MoveDish(Vector3 targetPosition)
	{
		return default(Vector3);
	}

	void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
	{
	}

	void IDragHandler.OnDrag(PointerEventData eventData)
	{
	}
}
