using System.Collections.Generic;

namespace MSKit.Currency
{
	public static class CurrencyManager
	{
		private static readonly Dictionary<Currency, BaseCurrencyController> _currencyDict;

		public static double GetCurrency(Currency currency)
		{
			return 0.0;
		}

		public static void AddCurrency(Currency currency, double amountToAdd)
		{
		}

		public static void DeductCurrency(Currency currency, double amountToDeduct)
		{
		}

		public static bool HasSufficientCurrency(Currency currency, double minAmount)
		{
			return false;
		}

		private static void InjectCurrency(Currency currency)
		{
		}
	}
}
