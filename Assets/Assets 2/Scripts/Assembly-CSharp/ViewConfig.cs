using MS.Casual.UI.Utilities;
using UnityEngine;

public class ViewConfig : ScriptableObject
{
	[Header("Level End")]
	public float LevelEndScreenDelay;

	[Header("In App Purchase")]
	public InAppMessage[] InAppMessages;

	[Header("Appreciation Banner")]
	public AppreciationBannerConfig AppreciationBannerConfigs;

	[Header("Boosters Data")]
	public BoostersConfig BoostersConfig;

	[Header("Cash")]
	public CashViewConfig CashViewConfigs;

	[Header("Cake")]
	public CakeConfig CakeConfigs;

	[Header("Grid Data")]
	public GridConfig GridConfigs;

	public LevelFailViewConfig LevelFailViewConfig;

	[Header("Notifications")]
	public int NotificationScheduleTimeInSecs;

	[Header("Dish")]
	public DishConfig DishConfigs;

	[Header("Upgrade Cards")]
	public ResourcesSprite[] FlowerCardSprites;

	[Header("Bar Sprites")]
	public ResourcesSprite BarGreenSprite;

	public ResourcesSprite BarYellowSprite;

	[Header("SPP Config")]
	public SPPConfig SPPConfig;

	[SerializeField]
	[Header("SPP Map Icon")]
	public SPPMapIconData[] SPPMapIconData;

	[Header("Speech Bubble")]
	public ResourcesSprite SpeechBubbleNormalBG;

	public ResourcesSprite SpeechBubbleCloseBG;

	[Header("Toggle")]
	public ToggleConfigs ToggleConfigs;

	[Header("Buttons")]
	public ButtonsData ButtonsData;

	public SPPMapIconData GetSPPMapIconData(int index)
	{
		return default(SPPMapIconData);
	}
}
