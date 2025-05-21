using UnityEngine;

[CreateAssetMenu(fileName = "DishTierObject", menuName = "ScriptableObjects/DishUpgradable/DishTierObject")]
public class DishTierObject : ScriptableObject
{
	public Mesh DishMesh;

	public Mesh DoubleMesh;

	public int DishScore;

	public Sprite Icon;

	public string Name;
}
