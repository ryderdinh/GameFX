using UnityEngine;

[CreateAssetMenu(fileName = "Appreciation Banner", menuName = "ScriptableObjects/AppreciationBanner")]
public class AppreciationBannerConfig : ScriptableObject
{
	[Header("Appreciation")]
	public float ProbabilityToShowBannerText;

	public float BannerAnimateInTime;

	public float BannerAnimateOutTime;

	public float BannerStayTime;

	public float MergeParticleDelay;

	public AnimationCurve OutBackCurve;

	public ValueRange ScreenBounds;

	public float ScreenPointDelta;

	public Sprite[] Numbers;

	public Sprite[] StreakNumbers;

	public AppreciationSpritesArray[] AppreciationSprites;

	public Sprite[] StageCompleteAffirmationSprites;

	public Sprite GetStageCompleteAffirmationSprite()
	{
		return null;
	}
}
