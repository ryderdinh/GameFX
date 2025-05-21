using UnityEngine;

public abstract class BaseBoosterProvider : MonoBehaviour, IBoosterProviderClick
{
	[SerializeField]
	protected BoosterProviderConfigs _baseConfigs;

	protected SpecialBoosterState state;

	protected float timeToCheckActivation;

	private float _processingTime;

	public abstract void LoadData();

	public virtual void Initialize(IBaseBoosterProvider baseBoosterProvider)
	{
	}

	public virtual void StartProcessing()
	{
	}

	public virtual void UpdateState(float deltaTime, float fixedDeltaTime)
	{
	}

	private void CheckTime()
	{
	}

	protected virtual void CheckActivation()
	{
	}

	protected virtual void ActivateSpecialBooster()
	{
	}

	protected virtual void ExecuteSpecialBooster()
	{
	}

	protected virtual void Reset()
	{
	}

	public void IBoosterProviderClick()
	{
	}
}
