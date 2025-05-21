using DG.Tweening;
using UnityEngine;

public class PieceSortCameraController : MonoBehaviour
{
	[SerializeField]
	private Transform _cameraTransform;

	[SerializeField]
	private Camera _camera;

	[SerializeField]
	private Camera _3DCamera;

	[SerializeField]
	private GameObject _postProcessingObject;

	private Camera _uiCamera;

	private Sequence _cameraSequence;

	private CameraConfigs _configs;

	private Tween _3DCameraSwitchTween;

	public void Initialize()
	{
	}

	private void RegisterEvents()
	{
	}

	private void UpdatePostProcessing()
	{
	}

	private void AddCameraInStack(CameraReference camera)
	{
	}

	public void StartGame()
	{
	}

	public void CompleteGame()
	{
	}

	public void GameStarted()
	{
	}

	public void FailGame()
	{
	}

	private void ChangeCameraStackForButterflySpawning()
	{
	}

	private void SetUICameraOnTop()
	{
	}

	private void GridBoosterViewCameraMoveOut()
	{
	}

	private void TrayBoosterViewCameraMoveOut()
	{
	}

	private void MoveInCamera(bool forced = false)
	{
	}

	private void MoveOutCamera(bool forced = false)
	{
	}

	private void MoveCamera(Vector3 pos, Vector3 rot, float posDuration, float rotDuration, bool forced = false)
	{
	}

	private void SetButterFlyCameraState(bool state)
	{
	}
}
