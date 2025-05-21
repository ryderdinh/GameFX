using UnityEngine;

namespace MS.Casual.UI.Utilities
{
	[CreateAssetMenu(menuName = "UI/Buttons/Button Color Data")]
	public class ButtonColorData : ScriptableObject
	{
		public ButtonColorType ButtonColorType;

		public ResourcesSprite TopSprite;

		public Color DepthColor;
	}
}
