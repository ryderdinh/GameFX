using System.Collections.Generic;
using UnityEngine;

namespace MSKit.ResourcePool
{
	public class Pool<T> where T : Component
	{
		private Transform _poolContainer;

		private readonly Queue<T> _poolObjects;

		private readonly List<T> _activeObjects;

		private T _objectToPool;

		private int _maxSize;

		public Pool(Transform parent, T objectToPool, int initialSize = 0, int maxSize = 10)
		{
		}

		public T Get()
		{
			return null;
		}

		public void Reset()
		{
		}

		public void Add(T obj)
		{
		}

		public void RemoveLast()
		{
		}

		public void Destroy()
		{
		}

		private void Populate(int size)
		{
		}

		private void Insert(T objectToPool)
		{
		}

		private void Extend(T objectToPool)
		{
		}

		private void RemoveOverloadedPool()
		{
		}

		private T Spawn(T objectToPool)
		{
			return null;
		}
	}
	public enum Pool
	{
		None = 0,
		LbEntries = 1
	}
}
