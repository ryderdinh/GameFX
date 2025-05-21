public abstract class CatState
{
	protected CatController _CatController;

	protected CatConfigs _Configs;

	public CatState(CatController catController, CatConfigs configs)
	{
	}

	public abstract void Enter();

	public abstract void Update();

	public abstract void Exit();
}
