using DB;
using UnityEngine;
using UnityEngine.Audio;

[CreateAssetMenu(menuName = "Data/AudioMixer", fileName = "AudioMixerSettings")]
public class SoundMixerController : ScriptableObject
{
	private const string MusicKey = "musicVolume";

	private const string SfxKey = "sfxVolume";

	public AudioMixer AudioMixer;

	public AudioMixerGroup AudioMixerMusicGroup;

	public AudioMixerGroup AudioMixerSFXGroup;

	[SerializeField]
	private DBFloat _dbMusicVolume;

	[SerializeField]
	private DBFloat _dbSfxVolume;

	private float _musicVolume;

	private float _sfxVolume;

	public float MusicVolume => 0f;

	public float SFXVolume => 0f;

	public void Initialize()
	{
	}

	public void SetMusicVolume(float value)
	{
	}

	public void SetSFXVolume(float value)
	{
	}
}
