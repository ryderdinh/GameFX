using Core.Server;
using DB;

public class PieceSortRefs : BaseGameRefs
{
	public SeasonalProgressPassSystem SeasonalProgressPassSystem;

	public GridPopulationSystem GridPopulationSystem;

	public GridController GridController;

	public TrayController TrayController;

	public BoingController BoingController;

	public BaseBoosterProvider ButterflyBoosterProvider;

	public PieceSortCameraController CameraController;

	public EnvironmentSetupController EnvironmentSetupController;

	public LevelUpGiftSpawner LevelUpGiftSpawner;

	public InAppReview InAppReview;

	public DBBool IsIARShown;

	public UserStateBackup UserStateBackup;
}
