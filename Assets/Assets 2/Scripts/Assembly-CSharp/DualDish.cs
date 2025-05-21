using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class DualDish : MonoBehaviour
{
	[SerializeField]
	private Transform _dualDishTransform;

	[SerializeField]
	private MeshFilter _meshFilter;

	private List<Dish> _dishes;

	private TrayType _trayType;

	private Sequence _dualDishSequence;

	private DishConfig _dishConfig;

	private int _dishColorId;

	private bool _isWarningActive;

	public void Initialize(TrayType trayType, List<Dish> dishes)
	{
	}

	public void ShowDualTray()
	{
	}

	public void RemoveDualTray()
	{
	}

	public void HideDualTray()
	{
	}

	public Sequence VanishDishSequence(float speed = 0.8f)
	{
		return null;
	}

	public void UpdateDualTrayWarningState(bool canPlace)
	{
	}

	private void CheckForDualDish()
	{
	}

	public void AnimateInDualDishWithDelay()
	{
	}

	private void AnimateInDualDish()
	{
	}

	private void HideSingleDishes()
	{
	}

	private void ActivateDishes()
	{
	}

	private void DeactivateDishes()
	{
	}

	private void ResetDualTray()
	{
	}

	private void SetDualDishState(bool state)
	{
	}

	private void ResetDualDishMaterial()
	{
	}

	private void ForceShowWarning()
	{
	}

	private void ShowDualDishWarning()
	{
	}

	public void UpdateDishMesh(Mesh mesh, bool animate = false)
	{
	}
}
