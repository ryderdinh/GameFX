using System;
using UnityEngine;

public struct CollectablesData
{
	public float Count;

	public Vector3 StartPos;

	public float CollectablesCount;

	public float StartDelay;

	public bool IsExtraBonus;

	public int ItemId;

	public bool WorldPosition;

	public Action CallBack;

	public bool IsBoosterMerge;

	public bool IsBunchAnimation;

	public bool ForceStartPositon;

	public float Duration;

	public float InitialSize;

	public float FinalSize;

	public float ScaleDuration;

	public bool IsTurboMode;

	public CollectablesData(float count, Vector3 startPos, float collectablesCount = 1f, float startDelay = 1.75f, bool isExtraBonus = false, int itemId = 0, Action callBack = null, bool isBunchAnimation = false, bool worldPosition = true, bool isBoosterMerge = false, bool forceStartPositon = false, float duration = 0.6f, float initialSize = 1f, float finalSize = 0.7f, float scaleDuration = 0.4f)
	{
		Count = 0f;
		StartPos = default(Vector3);
		CollectablesCount = 0f;
		StartDelay = 0f;
		IsExtraBonus = false;
		ItemId = 0;
		WorldPosition = false;
		CallBack = null;
		IsBoosterMerge = false;
		IsBunchAnimation = false;
		ForceStartPositon = false;
		Duration = 0f;
		InitialSize = 0f;
		FinalSize = 0f;
		ScaleDuration = 0f;
		IsTurboMode = false;
	}
}
