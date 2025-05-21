using UnityEngine;

[CreateAssetMenu(menuName = "Data/Sounds", fileName = "Sounds")]
public class SoundsData : ScriptableObject
{
	[NonReorderable]
	public SoundMixerController MixerController;

	[NonReorderable]
	public float SoundVolumeMultiplier;

	[NonReorderable]
	public BackgroundMusic[] m_BackgroundMusic;

	[NonReorderable]
	public SoundEffect[] m_SoundEffectArray;

	[NonReorderable]
	public MultiSoundEffect[] m_MultiSoundEffectArray;
}
