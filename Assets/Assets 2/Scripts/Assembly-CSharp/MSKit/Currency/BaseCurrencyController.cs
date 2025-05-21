using UnityEngine;

namespace MSKit.Currency
{
	public abstract class BaseCurrencyController : MonoBehaviour
	{
		public double TotalAmount { get; protected set; }

		public Currency CurrencyType { get; protected set; }

		public void Add(double value)
		{
		}

		public void Deduct(double value)
		{
		}

		public void LoadState(double initialAmount = 0.0)
		{
		}

		public void SaveState()
		{
		}

		public abstract void Initialize();
	}
}
