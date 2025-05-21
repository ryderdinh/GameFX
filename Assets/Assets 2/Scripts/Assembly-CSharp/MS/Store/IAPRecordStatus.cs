namespace MS.Store
{
	public enum IAPRecordStatus
	{
		IAPCallbackReceived = 0,
		PendingVerification = 1,
		Invalid = 2,
		Valid = 3,
		Test = 4,
		SkippedVerification = 5,
		Unknown = 6,
		FailedServerCall = 7,
		RewardClaimed = 8
	}
}
