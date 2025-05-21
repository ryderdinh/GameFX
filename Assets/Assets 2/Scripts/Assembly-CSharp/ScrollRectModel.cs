using System;
using UnityEngine;

[Serializable]
public class ScrollRectModel
{
	public RectTransform Panel;

	public RectTransform[] Rects;

	public RectTransform Center;

	public ScrollRectModel(RectTransform panel, RectTransform[] rects, RectTransform center)
	{
	}
}
