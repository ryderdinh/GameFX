using System.Collections.Generic;
using UnityEngine;

namespace MSKit.ResourcePool
{
	public class PoolManager : MonoBehaviour
	{
		[SerializeField]
		protected Transform _PoolContainer;

		private static Transform _poolContainer;

		private static readonly Dictionary<Pool, Pool<Component>> _poolObjects;

		private void Awake()
		{
		}

		public static void CreatePool<T>(Pool key, T obj, int initialSize = 1, int maxSize = 10) where T : Component
		{
		}

		public static void AddToPool<T>(Pool key, T objectToPool) where T : Component
		{
		}

		public static T GetFromPool<T>(Pool key, T objectToFind) where T : Component
		{
			return null;
		}

		public static void ResetPool<T>(Pool key) where T : Component
		{
		}

		public static void ResetPool(Pool key)
		{
		}

		public static void DestroyPool<T>(Pool key) where T : Component
		{
		}

		public static void DestroyPool(Pool key)
		{
		}

		private static void ExtendPool<T>(Pool key, T value, int initialSize = 0, int maxSize = 10) where T : Component
		{
		}
	}
}
