using System.Collections.Generic;
using UnityEngine;

namespace DB
{
	public abstract class Array<T> : ScriptableObject
	{
		public List<T> list;

		[SerializeField]
		protected bool ResetToDefaultOnPlay;

		public int Count => 0;

		public T this[int index] => default(T);

		private void OnEnable()
		{
		}

		public void Clear()
		{
		}

		public virtual bool Add(T t)
		{
			return false;
		}

		public void InsertAtIndex(int index, T t)
		{
		}

		public bool Remove(T t)
		{
			return false;
		}
	}
}
