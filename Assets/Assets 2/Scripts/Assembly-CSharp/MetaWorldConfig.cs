using UnityEngine;

[CreateAssetMenu(fileName = "MetaWorldConfigs", menuName = "Game/MetaWorldConfigs")]
public class MetaWorldConfig : ScriptableObject
{
	[SerializeField]
	private MetaSystem _metaSystem;

	public string[] MetaWorldNames;

	public Material MetaBgMaterial;

	public Vector3 DefaultPosition;

	public Vector3 DefaultRotation;

	public Vector3 DefaultScale;

	public Vector3 ActivePosition;

	public Vector3 ActiveRotation;

	public Vector3 ActiveScale;

	public float PositionDifferenceFactor;

	public float TransitionTime;

	public float MovementTime;

	public float ColorTransitionTime;

	[Header("Gameplay HUD Sprites")]
	public ResourcesSprite[] HudSprites;

	public Color[] InnerShadowColors;

	public Color[] SpriteBgColors;

	public ResourcesSprite TurboHudSprite;

	public Color TurboInnerShadowColor;

	public Color TurboSpriteBgColor;

	[Header("Force Rotation Configs")]
	public float PlatformAngleMultiplier;

	public float WorldAngleMultiplier;

	public float SkyboxAngleMultipler;

	public float RotationDuration;

	[Header("Upgradeables")]
	public ResourcesSprite UpgradeEnabledSprite;

	public ResourcesSprite UpgradeDisabledSprite;

	public Color GetInnerShadowColor(bool isTurboMode = false)
	{
		return default(Color);
	}

	public Color GetBgColor(bool isTurboMode = false)
	{
		return default(Color);
	}

	public ResourcesSprite GetHudSprite(bool isTurboMode = false)
	{
		return null;
	}

	public string GetMetaWorldName(int index)
	{
		return null;
	}

	public string GetCurrentMetaWorldName()
	{
		return null;
	}

	public int GetCurrentMetaInProgress()
	{
		return 0;
	}
}
