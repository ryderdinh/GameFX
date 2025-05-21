using System.Collections.Generic;

public class IntList : IPoolable
{
	private List<int> _list;

	public List<int> List => null;

	public void Add(int item)
	{
	}

	public void Remove(int item)
	{
	}

	public void Clear()
	{
	}

	public bool Contains(int item)
	{
		return false;
	}

	void IPoolable.ResetForPool()
	{
	}
}
