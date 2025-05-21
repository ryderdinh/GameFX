using UnityEngine;

[CreateAssetMenu(fileName = "EnvironmentSetup", menuName = "ScriptableObjects/Environment/EnvironmentSetup")]
public class EnvironmentSetup : ScriptableObject
{
	public Vector3 EnvironmentPropsPosition;

	public Vector3 EnvironmentPropsRotation;

	public EnvironmentProps EnvironmentProps;

	public ResourcesMesh TrayContainerMesh;

	public ResourcesMaterial TrayContainerMaterial;

	public ResourcesMesh GridBgMesh;

	public ResourcesMaterial GridBgMaterial;

	public ResourcesMesh GridBorderMesh;

	public ResourcesMaterial GridBorderMaterial;

	public ResourcesMaterial TilesMaterial;

	public EnvironmentProps SpawnPropsAndTiles()
	{
		return null;
	}
}
