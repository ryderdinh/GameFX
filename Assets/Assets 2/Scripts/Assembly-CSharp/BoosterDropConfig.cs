using System;
using DG.Tweening;
using UnityEngine;

[Serializable]
public struct BoosterDropConfig
{
	public Vector3 SlotPositionDelta;

	public Ease DropCurve;

	public float Duration;

	public float InitialScale;

	public float JumpPower;

	public float JumpScale;

	public float FinalScale;
}
