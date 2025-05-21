using System;
using UnityEngine;

[Serializable]
public struct CardUIAdjustmentData
{
	public Vector2[] SpinnerSize;

	public Vector2[] SpinnerDescriptionSize;

	public SpinnerPostionData[] SpinnerPositionData;

	public float[] SpinnerScaleOnSelection;

	public float[] SpinnerDescriptionsFontSize;

	public Vector2[] BoosterImageSize;

	public float[] AnimatedCardScaleFactor;
}
