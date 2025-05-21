using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;

public class Tray : MonoBehaviour, IPointerUpHandler, IEventSystemHandler, IPointerDownHandler, IPointerClickHandler
{
	[SerializeField]
	private BoxCollider _trayCollider;

	[SerializeField]
	private DualDish _dualDish;

	private int _id;

	private List<Dish> _dishes;

	private TrayType _trayType;

	private Vector2 _position;

	private Vector3 _initialTrayPosition;

	private Vector3 _initialTrayScale;

	private ITray _trayController;

	private TrayState _trayState;

	private Sequence _traySequence;

	private bool _trayActive;

	public int ID => 0;

	public Vector3 Position => default(Vector3);

	public TrayType TrayType => default(TrayType);

	public TrayState TrayState => default(TrayState);

	public List<Dish> Dishes => null;

	public DualDish DualDish => null;

	public void Initialize(int id, ITray trayController)
	{
	}

	public void ReInitialize(TrayType trayType)
	{
	}

	public void InitializationComplete()
	{
	}

	public void SetParent(Transform parent)
	{
	}

	public List<int> ForceCompleteTray(float delay = 0f)
	{
		return null;
	}

	public void MoveToInactiveState()
	{
	}

	public void UpdateDualTrayWarningState(bool canPlace)
	{
	}

	public void UpdateDishMesh(Mesh mesh, Mesh dualDishMesh)
	{
	}

	public void DowngradeDishMesh(Mesh mesh, Mesh dualDishMesh)
	{
	}

	private void AdjustTrayCollider()
	{
	}

	private void ResetTrayCollider()
	{
	}

	private void ResetTrayScale()
	{
	}

	public void AddDish(Dish dish)
	{
	}

	public void ScaleUpTray()
	{
	}

	public void ScaleUpTrayOnClick(float scaleFactor)
	{
	}

	public Sequence VanishDishes()
	{
		return null;
	}

	public void WaterCanWobbleDish()
	{
	}

	public Vector3 MoveTray(Vector3 targetPosition)
	{
		return default(Vector3);
	}

	public void ForcePlaceBackOnGrid()
	{
	}

	public void ResetTrayPosition()
	{
	}

	private void AnimateTray()
	{
	}

	private void PutTrayBackInPlace()
	{
	}

	public void SetPosition(Vector3 position)
	{
	}

	public void SetScale(float scaleFactor)
	{
	}

	public void RemoveDishes()
	{
	}

	public void ResetTray()
	{
	}

	public void TraySnappedOnGrid()
	{
	}

	public void ResetTrayLocalPosition()
	{
	}

	private void SetNewDishPosition()
	{
	}

	void IPointerUpHandler.OnPointerUp(PointerEventData eventData)
	{
	}

	void IPointerDownHandler.OnPointerDown(PointerEventData eventData)
	{
	}

	void IPointerClickHandler.OnPointerClick(PointerEventData eventData)
	{
	}

	public void IncrementFlowerTierInDish(int id)
	{
	}

	public void PlayDishFlowerRotationParticles(int cakeId)
	{
	}

	public void StopDishFlowerRotationParticles()
	{
	}

	public void SetTrayMovingState(bool state)
	{
	}
}
