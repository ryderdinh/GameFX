using System.Collections.Generic;

public abstract class ArrayObject<T>
{
	public readonly List<T> list;

	public T this[int index] => default(T);

	public int Count => 0;

	protected ArrayObject()
	{
	}

	protected ArrayObject(List<T> list)
	{
	}

	public void Add(T t)
	{
	}
}
