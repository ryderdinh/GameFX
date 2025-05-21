namespace MS.Casual.Market
{
	public interface IInAppReward<in TDataType> where TDataType : InAppItemData
	{
		void GiveReward(TDataType data, bool isRestore);
	}
}
