using UnityEngine;

[CreateAssetMenu(fileName = "CashViewConfigs", menuName = "Game/CashView")]
public class CashViewConfig : ScriptableObject
{
	public float CoinMoveAnimationDuration;

	public float CoinMoveInBetweenDelay;

	public float CoinIconScaleFactor;

	public float CoinIconScaleAnimationDuration;

	public float CoinMoveBunchAnimationDuration;

	public float CoinBunchSpreadDuration;

	public float CoinBunchSpreadDistance;

	public float CoinBunchSpreadDelay;
}
