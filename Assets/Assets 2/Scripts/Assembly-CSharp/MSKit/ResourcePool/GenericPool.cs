using System.Collections.Generic;

namespace MSKit.ResourcePool
{
	public abstract class GenericPool<T> where T : IPoolable
	{
		private readonly Queue<T> _poolObjects;

		private readonly List<T> _activeObjects;

		private int _maxSize;

		protected abstract T GetNewInstance();

		public GenericPool(int initialSize = 0, int maxSize = 10)
		{
		}

		public T Get()
		{
			return default(T);
		}

		public void Reset()
		{
		}

		public void Add(T obj)
		{
		}

		private void Populate(int size)
		{
		}

		private void Insert(T objectToPool)
		{
		}

		private void RemoveOverloadedPool()
		{
		}
	}
}
