using System.Collections.Generic;

namespace MSKit.ResourcePool
{
	public abstract class PrimitiveListPool<T> where T : struct
	{
		private readonly Queue<List<T>> _poolObjects;

		private readonly List<List<T>> _activeObjects;

		private int _maxSize;

		public PrimitiveListPool(int initialSize = 0, int maxSize = 10)
		{
		}

		public List<T> Get()
		{
			return null;
		}

		public void Reset()
		{
		}

		public void Add(List<T> obj)
		{
		}

		private void Populate(int size)
		{
		}

		private void Insert(List<T> objectToPool)
		{
		}

		private void RemoveOverloadedPool()
		{
		}
	}
}
