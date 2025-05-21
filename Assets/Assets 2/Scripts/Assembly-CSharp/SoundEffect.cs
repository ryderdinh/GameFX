using System;
using UnityEngine;

[Serializable]
public struct SoundEffect
{
	public SoundType type;

	public AudioClip clip;

	public float Volume;

	public ValueRange Pitch;
}
