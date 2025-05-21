using System;
using UnityEngine;

[Serializable]
public struct AnimatedCardsData
{
	public Animator CardsAnimator;

	public RectTransform CardsRect;

	public RectTransform CardsShadowRect;

	public RectTransform CardsQuestionMarkRect;

	public GameObject Card;
}
