using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "DailyLoginController", menuName = "ScriptableObjects/DailyLogin/DailyLoginController")]
public class DailyLoginController : ScriptableObject
{
	[SerializeField]
	private DBLong _dbLastLoginDate;

	public void Login()
	{
	}
}
