using UnityEngine;

[CreateAssetMenu(fileName = "BaseBoostersSpinnerConfigs", menuName = "Views/BaseBoostersSpinnerConfigs")]
public class PowerUpsSpinnerConfigs : ScriptableObject
{
	public float Padding;

	public float SpinSpeed;

	public float SpinAccelerationTime;

	public float AutoStopTime;

	public bool IsEnableFirstDefaultImage;

	public Sprite FirstDefaultImage;

	public Sprite[] FirstDefaultImageBg;

	public BoosterProbabilityLevelsConfigs BoosterProbabilityLevelsConfigs;

	public int RespinsLimit;

	public int SkipRespinCount;

	public int IgnoreBoosterRepeatCount;

	public Vector3 IconPositionOnBaseView;

	public int HandTutorialLimit;

	public int HandTutorialDelayAfterCount;

	public float HandTutorialDelay;
}
