using UnityEngine;

public class Overlay : MonoBehaviour
{
	[SerializeField]
	private Material _overlayMaterial;

	[SerializeField]
	private GameObject _overlayObj;

	[SerializeField]
	private Vector3 _overlayPositionForGrid;

	[SerializeField]
	private Vector3 _overlayPositionForTray;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void SetOverlayFade(bool state)
	{
	}

	private void SetOverlayObjState(bool state)
	{
	}

	private void SetOverlayState(bool state)
	{
	}

	private void MoveOverlayForTray()
	{
	}
}
