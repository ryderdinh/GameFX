public interface IButterfly : IBaseBoosterProvider
{
	float GetBoardState();

	void ForceTrayBackInPlace();

	void ButterflyTutorialActivated();

	void ButterflyTutorialCompleted();
}
