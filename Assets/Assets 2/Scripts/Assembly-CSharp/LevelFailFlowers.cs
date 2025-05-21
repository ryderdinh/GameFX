using DB;
using DG.Tweening;
using UnityEngine;

public class LevelFailFlowers : MonoBehaviour
{
	[SerializeField]
	private GameObject _flower;

	[SerializeField]
	private Transform _flowerTransform;

	[SerializeField]
	private Transform _unlockedFlowerParent;

	[SerializeField]
	private Dish _dish;

	[SerializeField]
	private Material _levelEndPetalsMaterial;

	[SerializeField]
	private ArrayInt _arrayInt;

	[SerializeField]
	private ItemSystem _itemSystem;

	private DishConfig _dishConfig;

	private Sequence _flowerPotSequence;

	private Vector3 _defaultScale;

	public void Initialize()
	{
	}

	public void Reset()
	{
	}

	public void Show()
	{
	}

	private void SpawnPetals()
	{
	}

	private void RotateDishSequence(Transform dishTransform)
	{
	}

	public void FlowerCompleteOnLevelEnd()
	{
	}

	private void SetFlowerState(bool state)
	{
	}

	private void SetDishState(bool state)
	{
	}
}
