using UnityEngine;

[CreateAssetMenu(fileName = "CakeTierData", menuName = "ScriptableObjects/CakeTierData", order = 1)]
public class FlowerTierData : ScriptableObject
{
	public Flower Object;

	public FlowerUIObject CakeUIObject;

	public int TierScore;

	public ResourcesMesh MidMesh;

	public ResourcesTexture FlowerTexture;

	public string FlowerName;

	public int Cost;

	public int CardsRequiredToUnlock;
}
