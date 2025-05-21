using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "CardsChests", menuName = "ScriptableObjects/Cards/CardsChests")]
public class CardsChestData : ScriptableObject
{
	public List<CardsChest> CardsChests;
}
