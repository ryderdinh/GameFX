using System;
using UnityEngine;

[Serializable]
public struct RewardObject
{
	public RewardType RewardType;

	public int RewardSubIndex;

	public int Amount;

	public Sprite RewardIcon;
}
