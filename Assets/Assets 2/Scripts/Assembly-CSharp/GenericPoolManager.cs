using System.Collections.Generic;
using MSKit.ResourcePool;
using UnityEngine;

public class GenericPoolManager : MonoBehaviour
{
	private static readonly Dictionary<GenericPools, GenericPool<IPoolable>> _poolObjects;

	public static void CreatePool<T>(GenericPools key, int initialSize = 1, int maxSize = 10) where T : IPoolable
	{
	}

	public static void AddToPool<T>(GenericPools key, T objectToPool) where T : IPoolable
	{
	}

	public static T GetFromPool<T>(GenericPools key) where T : IPoolable
	{
		return default(T);
	}

	public static void ResetPool<T>(GenericPools key) where T : IPoolable
	{
	}

	private static void ExtendPool(GenericPools key, int initialSize = 0, int maxSize = 10)
	{
	}
}
