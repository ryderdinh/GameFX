using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DG.Tweening;
using UnityEngine;

public class SoundsController : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class _003CCacheAudioSource_003Ed__23 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public float time;

		public SoundsController _003C_003E4__this;

		public AudioSource source;

		object IEnumerator<object>.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		object IEnumerator.Current
		{
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[DebuggerHidden]
		public _003CCacheAudioSource_003Ed__23(int _003C_003E1__state)
		{
		}

		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		private bool MoveNext()
		{
			return false;
		}

		bool IEnumerator.MoveNext()
		{
			//ILSpy generated this explicit interface implementation from .override directive in MoveNext
			return this.MoveNext();
		}

		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	private SoundsData _soundsData;

	private Stack<AudioSource> _audioSourcesSfx;

	private AudioSource _loopedAudioSource;

	private Stack<AudioSource> _audioSourcesAmbient;

	private Stack<AudioSource> _audioSourcesBG;

	private AudioSource _currentAmbientAudioSource;

	private AudioSource _currentBGAudioSource;

	private AudioSource _loopSoundEffectAudioSource;

	private Tween _bgStartTween;

	private Tween _bgEndTween;

	private Tween _ambientStartTween;

	private Tween _ambientEndTween;

	private MusicType _currentMusicType;

	private static SoundsController _instance;

	public bool BackgroundMusic { get; private set; }

	public bool SoundEffects { get; private set; }

	private static SoundsController FindController => null;

	private static SoundsController _soundController => null;

	private void Awake()
	{
	}

	private void LoadData()
	{
	}

	private void SavePrefsData()
	{
	}

	private void PlayMultiSoundEffect(SoundType sound)
	{
	}

	private void PlaySoundEffect(SoundType sound)
	{
	}

	private void PlayLoopedSoundEffect(SoundType sound)
	{
	}

	private AudioSource PlayEditableSoundEffect(SoundType sound)
	{
		return null;
	}

	private void PlayMultiSoundEffect(SoundType soundType, int combo, bool increasePitch)
	{
	}

	private void PlaySoundEffect(AudioClip clip, float volume, float pitch)
	{
	}

	private void PlayLoopedSoundEffect(AudioClip clip, float volume, float pitch)
	{
	}

	private void StopLoopedSoundEffect()
	{
	}

	private AudioSource PlayEditableSoundEffect(AudioClip clip, float volume, float pitch)
	{
		return null;
	}

	[IteratorStateMachine(typeof(_003CCacheAudioSource_003Ed__23))]
	private IEnumerator CacheAudioSource(AudioSource source, float time)
	{
		return null;
	}

	private AudioSource GetAudioSource()
	{
		return null;
	}

	private AudioSource CreateAudioSource(string name)
	{
		return null;
	}

	private MultiSoundEffect GetMultiSoundData(SoundType sound)
	{
		return default(MultiSoundEffect);
	}

	private SoundEffect GetSoundData(SoundType sound)
	{
		return default(SoundEffect);
	}

	public static void PlayBGMusic(MusicType type, bool isResumed = false, bool fade = true, float fadeDuration = 1f)
	{
	}

	public static void StopBGMusic(bool pause = false, bool fade = true, float fadeDuration = 1f)
	{
	}

	public static void PlayAmbientMusic(MusicType type, int index, bool fade = true, float fadeDuration = 1f)
	{
	}

	public static void StopAmbientMusic(bool fade = true, float fadeDuration = 0.5f)
	{
	}

	private void PlayAmbientEffect(MusicType type, int index, bool fade, float fadeDuration)
	{
	}

	private void PlayBackgroundMusicEffect(MusicType type, bool isResumed, bool fade, float fadeDuration)
	{
	}

	private void PlayMusicEffect(AudioSource source, MusicType type, int clipIndex, bool fade, float fadeDuration, ref Tween tween)
	{
	}

	private void StopAmbientMusicEffect(bool fade, float fadeDuration)
	{
	}

	private void StopBackgroundMusicEffect(bool pause, bool fade, float fadeDuration)
	{
	}

	private void StopMusicEffect(AudioSource source, bool fade, float fadeDuration, bool pause, ref Tween tween)
	{
	}

	private void ClearMusicSource(AudioSource source, bool pause)
	{
	}

	private void InitializeMusicAudioSources()
	{
	}

	private BackgroundMusic GetMusicSoundClip(MusicType type)
	{
		return default(BackgroundMusic);
	}

	public static void SetSoundState(bool state)
	{
	}

	public static bool GetSoundEffectState()
	{
		return false;
	}

	public static bool GetMusicState()
	{
		return false;
	}

	public static void SetSoundEffectState(bool state)
	{
	}

	public static void SetMusicState(bool state)
	{
	}

	public static void PlayMultiSound(SoundType sound)
	{
	}

	public static void PlaySound(SoundType sound)
	{
	}

	public static void PlayLoopedSound(SoundType type)
	{
	}

	public static void StopLoopedSound()
	{
	}

	public static AudioSource PlayEditAbleSound(SoundType sound)
	{
		return null;
	}

	public static void PlayMultiSound(SoundType soundType, int combo, bool increasePitch = false)
	{
	}

	public static void PlayDelayedSound(SoundType sound, float delay)
	{
	}
}
