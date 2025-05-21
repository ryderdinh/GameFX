using MS.Store;
using UnityEngine;

public class UnityInAppManager : MonoBehaviour
{
	private static UnityInAppManager _instance;

	[SerializeField]
	private IAPStore _iAPStore;

	private void Awake()
	{
	}

	private void Start()
	{
	}
}
