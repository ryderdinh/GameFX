using UnityEngine;

[CreateAssetMenu(fileName = "BoostersConfig", menuName = "Game/Boosters")]
public class BoostersConfig : ScriptableObject
{
	[Header("Boosters")]
	public BoostersController BoostersController;
}
