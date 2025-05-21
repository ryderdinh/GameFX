using MS.Casual.IAP;
using TMPro;

namespace MS.Casual.Market
{
	public abstract class BaseMarketItemView : BaseInAppItemView
	{
		public MarketItemData ProductData;

		public TextMeshProUGUI CoinsText;

		protected TransactionRecord _product;

		public override void OnItemShown()
		{
		}

		protected override void PreInitialize()
		{
		}

		protected override void Initialize()
		{
		}

		protected virtual void UpdateData()
		{
		}

		protected virtual void OnInAppInitialize(TransactionRecord[] products)
		{
		}

		protected override void BuyItem()
		{
		}
	}
}
