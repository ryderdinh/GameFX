using System;
using System.Collections.Generic;

namespace MSKit.Events
{
	public class Observable
	{
		private readonly HashSet<Action> _actions;

		protected ObserverType _ObserverType;

		public Observable(ObserverType type)
		{
		}

		private void AddObserver(Action action)
		{
		}

		private void RemoveObserver(Action action)
		{
		}

		public void Fire()
		{
		}

		public static Observable operator +(Observable events, Action action)
		{
			return null;
		}

		public static Observable operator -(Observable events, Action action)
		{
			return null;
		}

		protected bool Validate(ObserverType type)
		{
			return false;
		}

		private void LogWarning(ObserverType type)
		{
		}
	}
	public class Observable<T> : Observable where T : struct
	{
		private readonly HashSet<Func<T>> _functions;

		private readonly HashSet<Action<T>> _actions;

		public Observable(ObserverType type)
			: base(default(ObserverType))
		{
		}

		private void AddObserver(Action<T> action)
		{
		}

		private void RemoveObserver(Action<T> action)
		{
		}

		private void AddObserver(Func<T> action)
		{
		}

		private void RemoveObserver(Func<T> action)
		{
		}

		public void Fire(T param)
		{
		}

		public new T Fire()
		{
			return default(T);
		}

		public static Observable<T> operator +(Observable<T> events, Action<T> action)
		{
			return null;
		}

		public static Observable<T> operator -(Observable<T> events, Action<T> action)
		{
			return null;
		}

		public static Observable<T> operator +(Observable<T> events, Func<T> action)
		{
			return null;
		}

		public static Observable<T> operator -(Observable<T> events, Func<T> action)
		{
			return null;
		}
	}
	public class Observable<ParameterType, ReturnType> : Observable where ParameterType : struct where ReturnType : struct
	{
		private readonly HashSet<Func<ParameterType, ReturnType>> _actions;

		public Observable(ObserverType type)
			: base(default(ObserverType))
		{
		}

		private void AddObserver(Func<ParameterType, ReturnType> action)
		{
		}

		private void RemoveObserver(Func<ParameterType, ReturnType> action)
		{
		}

		public ReturnType Fire(ParameterType param)
		{
			return default(ReturnType);
		}

		public static Observable<ParameterType, ReturnType> operator +(Observable<ParameterType, ReturnType> events, Func<ParameterType, ReturnType> action)
		{
			return null;
		}

		public static Observable<ParameterType, ReturnType> operator -(Observable<ParameterType, ReturnType> events, Func<ParameterType, ReturnType> action)
		{
			return null;
		}
	}
}
