using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Text))]
public class FPSCounter : MonoBehaviour
{
	public float UpdateInterval;

	protected float _framesAccumulated;

	protected float _framesDrawnInTheInterval;

	protected float _timeLeft;

	protected Text _text;

	protected virtual void Start()
	{
	}

	protected virtual void Update()
	{
	}
}
