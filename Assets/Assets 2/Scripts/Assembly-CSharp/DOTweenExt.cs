using DG.Tweening;
using UnityEngine;

public static class DOTweenExt
{
	public static Tween DOInvoke(this Object targetObject, float delay, TweenCallback callback)
	{
		return null;
	}

	public static Tween DOInt(this Object targetObject, int startValue, int endValue, float time, TweenCallback<int> onUpdate)
	{
		return null;
	}

	public static Tween DOFloat(float from, float to, float duration, TweenCallback<float> onVirtualUpdate)
	{
		return null;
	}

	public static Tween DOFloat(this Object targetObject, float startValue, float endValue, float time)
	{
		return null;
	}

	public static Tween DOFloat(this Object targetObject, float startValue, float endValue, float time, TweenCallback<float> onUpdate)
	{
		return null;
	}

	public static Tween DOVector2(this Object targetObject, Vector2 startValue, Vector2 endValue, float time, TweenCallback<Vector2> onUpdate)
	{
		return null;
	}

	public static Tween DOVector3(this Object targetObject, Vector3 startValue, Vector3 endValue, float time, TweenCallback<Vector3> onUpdate)
	{
		return null;
	}
}
