using UnityEngine;

public class GridShadow : MonoBehaviour
{
	[SerializeField]
	private Transform _shadow;

	[SerializeField]
	private float _shadowNormalZPosition;

	[SerializeField]
	private float _shadowBoosterViewZPosition;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void RegisterEvents()
	{
	}

	private void UnRegisterEvents()
	{
	}

	private void MoveInShadowForBooster()
	{
	}

	private void MoveOutShadowToNormal(bool forced = false)
	{
	}

	private void MoveShadow(float position)
	{
	}
}
