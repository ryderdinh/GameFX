using UnityEngine;

public class SPPMapIconController : MonoBehaviour
{
	[SerializeField]
	private SPPMapIcon[] _propItems;

	private bool _isInitialized;

	private int _scrollConstant;

	private int _maxJewels;

	private float _previousScrollValue;

	private const int _gapInJewels = 2;

	private SeasonalProgressPassSystem _seasonalProgressPassSystem;

	public void Initialize(SeasonalProgressPassSystem seasonalProgressPassSystem)
	{
	}

	public void Show()
	{
	}

	public void UpdatePropPosition(float currentScrollValue)
	{
	}

	private void SetInitialProps()
	{
	}

	private void InitializeProp(float scrollValue, int index)
	{
	}

	private int CalculateGapBetweenProps(float currentScrollValue)
	{
		return 0;
	}

	private void CalculateNewState(float currentScrollValue, int gapBetweenProps)
	{
	}

	private void Update()
	{
	}
}
