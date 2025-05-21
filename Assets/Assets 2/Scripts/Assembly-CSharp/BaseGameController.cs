using UnityEngine;

public abstract class BaseGameController : MonoBehaviour
{
	public abstract void LoadGame(ILevelData dataModel);

	public abstract void PostLoadGame();

	public abstract void StartGame();

	public abstract void CompleteGame();

	public abstract void FailGame();

	public abstract void UnLoadGame();

	public abstract void Initialize();
}
public abstract class BaseGameController<T> : BaseGameController where T : BaseGameRefs
{
	public T GameRefs { get; private set; }

	public abstract void RegisterEvents();

	public abstract void UnregisterEvents();

	public override void LoadGame(ILevelData dataModel)
	{
	}

	public override void UnLoadGame()
	{
	}

	public override void Initialize()
	{
	}
}
