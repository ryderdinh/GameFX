using System;
using UnityEngine;

[Serializable]
public struct BackgroundMusic
{
	public MusicType Type;

	public AudioClip[] Clip;

	public float Volume;

	public ValueRange Pitch;
}
