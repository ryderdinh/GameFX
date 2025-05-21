using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "BoosterDropObject", menuName = "Game/BoosterDropSystem")]
public class BoosterDropSystem : ScriptableObject
{
	private int _slotID;

	[SerializeField]
	private BoostersController _boostersController;

	[SerializeField]
	protected BoosterDropConfig _BoosterDropConfig;

	[Tooltip("in seconds")]
	[SerializeField]
	protected float _DropObjectDisappearTime;

	protected IBaseBoosterProvider _BoosterProvider;

	protected List<Boosters> _AllBoosters;

	protected BoosterDropData _BoosterDropData;

	[SerializeField]
	protected BoostersTypes _SpecifiedBooster;

	public virtual void Initialize(IBaseBoosterProvider boosterProvider)
	{
	}

	public void DropSpecifiedReward()
	{
	}
}
