using UnityEngine;

public struct CustomFloaterText
{
	public string Text;

	public Vector2 StartPos;

	public float YOffset;

	public CustomFloaterText(string text, Vector2 startPos, float yOffset)
	{
		Text = null;
		StartPos = default(Vector2);
		YOffset = 0f;
	}
}
