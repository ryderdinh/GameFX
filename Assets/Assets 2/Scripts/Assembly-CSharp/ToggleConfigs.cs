using UnityEngine;

[CreateAssetMenu(fileName = "ToggleConfigs", menuName = "Game/Toggle")]
public class ToggleConfigs : ScriptableObject
{
	[Header("Toggle Anchor")]
	public float HandleChangeInPosition;

	public float HandleAnchorDuration;

	public float PunchScaleFactor;

	public float HandlePunchScaleDuration;

	public float HandlePunchScaleDelay;

	[Header("Bg Color")]
	public float BgColorDuration;

	[Header("Text Fade")]
	public float TextFadeDuration;

	[Header("Handle Sprite")]
	public ResourcesSprite ToggleOnHandleSprite;

	public ResourcesSprite ToggleOffHandleSprite;

	[Header("Scale Status Text")]
	public float TextScaleDuration;

	[Header("Bg Color")]
	public Color ToggleOnColor;

	public Color ToggleOffColor;
}
