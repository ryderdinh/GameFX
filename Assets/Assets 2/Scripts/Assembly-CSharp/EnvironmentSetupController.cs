using System.Collections.Generic;
using UnityEngine;

public class EnvironmentSetupController : MonoBehaviour
{
	[SerializeField]
	private MetaSystem _metaSystem;

	[SerializeField]
	private List<EnvironmentSetup> _environmentSetups;

	[SerializeField]
	private EnvironmentSetup _turboModeSetup;

	[SerializeField]
	private MeshFilter _trayContainerMeshFilter;

	[SerializeField]
	private MeshRenderer _trayContainerMeshRenderer;

	[SerializeField]
	private MeshFilter _gridBgMeshFilter;

	[SerializeField]
	private MeshRenderer _gridBgMeshRenderer;

	[SerializeField]
	private MeshFilter _gridBorderMeshFilter;

	[SerializeField]
	private MeshRenderer _gridBorderMeshRenderer;

	private int _worldID;

	private EnvironmentProps _props;

	public void Initialize()
	{
	}

	private void RegisterEvents()
	{
	}

	public void SetupEnvironment()
	{
	}

	public void TurboModeActivated(bool state)
	{
	}

	private void SetupEnvironment(int worldIndex)
	{
	}

	private void SetupTiles()
	{
	}
}
