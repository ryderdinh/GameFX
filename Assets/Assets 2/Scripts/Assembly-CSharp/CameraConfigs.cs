using UnityEngine;

[CreateAssetMenu(fileName = "CameraConfigs", menuName = "Camera")]
public class CameraConfigs : ScriptableObject
{
	[Header("Position")]
	public Vector3 StartPosition;

	public Vector3 TargetPosition;

	public Vector3 LevelFailMoveOutTargetPosition;

	public float LevelFailMoveOutPositionTransitionDuration;

	public float PositionTransitionDuration;

	[Header("Rotation")]
	public Vector3 StartRotation;

	public Vector3 TargetRotation;

	public Vector3 LevelFailMoveOutRotation;

	public float LevelFailMoveOutRotationTransitionDuration;

	public float RotationTransitionDuration;

	[Header("Grid Booster View Camera Position")]
	public Vector3 GridBoosterViewCameraPosition;

	public Vector3 GridBoosterViewCameraRotation;

	public float GridBoosterViewCameraPositionTransitionDuration;

	[Header("Tray Booster View Camera Position")]
	public Vector3 TrayBoosterViewCameraPosition;

	public Vector3 TrayBoosterViewCameraRotation;

	public float TrayBoosterViewCameraPositionTransitionDuration;
}
