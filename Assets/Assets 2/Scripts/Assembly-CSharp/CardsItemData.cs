using UnityEngine;

[CreateAssetMenu(menuName = "Market/CardsItemData", fileName = "CardsItemData")]
public class CardsItemData : ScriptableObject
{
	public ResourcesTexture CardPackTexture;

	public int CardsToAddLimit;

	public CardsData[] Cards;
}
