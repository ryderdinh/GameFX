using UnityEngine;
using UnityEngine.UI;

public class SPPMapIcon : MonoBehaviour
{
	[SerializeField]
	private ValueRangeInt _itemRange;

	[SerializeField]
	private RectTransform _itemTransform;

	[SerializeField]
	private SPPMapIconDirection _direction;

	[SerializeField]
	private Image _jewelIcon;

	private Vector3 _itemDisplayPosition;

	private Vector3 _itemOutPosition;

	private ValueRange _normalizedRange;

	private float _rangeMidPoint;

	private Vector3 _finalPosition;

	private int _scrollConstant;

	private int _jewelIndex;

	private int _gapInJewels;

	public int JewelIndex => 0;

	public void Initialize(int scrollConstant, int gapInJewels)
	{
	}

	public virtual void UpdatePropPosition()
	{
	}

	public virtual bool CalculatePropPosition(float currentScrollValue)
	{
		return false;
	}

	public void SetNewState(int newPropPosition, int iconIndex)
	{
	}

	private void ForceMoveOutItem()
	{
	}

	private void CalculateInitialValues()
	{
	}

	private void SetState(bool state)
	{
	}
}
