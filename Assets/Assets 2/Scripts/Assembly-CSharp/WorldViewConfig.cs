using UnityEngine;

[CreateAssetMenu(fileName = "MetaWorldRotationConfigs", menuName = "Game/MetaWorldRotationConfigs")]
public class WorldViewConfig : ScriptableObject
{
	[Header("Rotation Configs")]
	public float OrbRotationSpeed;

	public float OrbDragStartThreshold;

	public float OrbMinDragThreshold;

	public float OrbHoldDragThreshold;

	public float OrbMaxDrag;

	public float OrbInertiaOnDragRelease;

	public float OrbInertiaOnLoad;

	public float OrbDragOnLoad;

	public float InputNormalizedValue;

	public float OrbNormalYPosition;

	public float OrbExtraTrayYPosition;

	public float OrbBannerYPosition;

	public float OrbBgNormalYPosition;

	public float OrbBgExtraTrayYPosition;

	public float OrbBgBannerYPosition;

	public float MinRotationAngle;

	public float MaxRotationAngle;

	[Header("Platform")]
	public float PlatformRotationSpeed;

	public float PlatformRotationLimit;

	[Header("Skybox")]
	public float SkyBoxRotationSpeed;

	public float SkyBoxRotationLimit;

	[Header("World")]
	public float WorldRotationSpeed;

	public float WorldRotationLimit;
}
