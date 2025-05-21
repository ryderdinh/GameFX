using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using DB;
using UnityEngine;

[CreateAssetMenu(fileName = "LiveOpsSystem", menuName = "ScriptableObjects/LiveOps/LiveOpsSystem")]
public class LiveOpsSystem : ScriptableObject, ILiveOps
{
	[CompilerGenerated]
	private sealed class _003CEventTimerCoroutine_003Ed__50 : IEnumerator<object>, IEnumerator, IDisposable
	{
		private int _003C_003E1__state;

		private object _003C_003E2__current;

		public LiveOpsSystem _003C_003E4__this;

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
		public _003CEventTimerCoroutine_003Ed__50(int _003C_003E1__state)
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

	[SerializeField]
	private MissionSystemController _missionSystemController;

	[SerializeField]
	private SeasonalProgressPassSystem _seasonalProgressPassSystem;

	[SerializeField]
	private MetaWorldConfig _metaWorld;

	[SerializeField]
	private LevelSystem _levelSystem;

	[SerializeField]
	private DBTime _dbDailyEventEndTime;

	[SerializeField]
	private DBBool _dbIsEventStarted;

	[SerializeField]
	private DBBool _dbIsEventZeroDayLoggedIn;

	[SerializeField]
	private DBBool _dbIsEventAcknowledged;

	[SerializeField]
	private double _eventStartTime;

	[SerializeField]
	private long _eventDurationInSec;

	[SerializeField]
	private int _eventUnlockedWorld;

	[SerializeField]
	private int _eventUnlockedLevel;

	[SerializeField]
	private int _forceToOpenMenuOnLevelNo;

	[Header("LiveOpsOffers")]
	[SerializeField]
	private DBBool _dbBoolAllOffersPurchased;

	private MonoBehaviour _coroutineRunner;

	private Coroutine _eventTimerCR;

	private WaitForSeconds _wait;

	private DateTime _epochTime;

	private double _eventEndTime;

	private int _eventRemainingTime;

	private DateTime _eventStartDate;

	private int _dailyRemainingTime;

	private DateTime _dailyEventEndTime;

	private EventTimeData _eventTimeData;

	private bool _isEventActive;

	private bool _allOffersPurchased;

	public bool AllOffersPurchased => false;

	public bool IsEventZeroDayLoggedIn => false;

	public void Initialize(MonoBehaviour coroutineRunner)
	{
	}

	public void OnAllOffersPurchased()
	{
	}

	public bool CanShowLiveOpsOffer()
	{
		return false;
	}

	public bool IsEventActive()
	{
		return false;
	}

	public int ForceToOpenMenuOnLevelNo()
	{
		return 0;
	}

	public bool IsEventReadyToStart()
	{
		return false;
	}

	public int GetEventRemainingEvent()
	{
		return 0;
	}

	public int GetDailyRemainingEvent()
	{
		return 0;
	}

	public void ResetMissionProgress(MissionType missionType)
	{
	}

	public int GetNumberOfMissionsCompleted()
	{
		return 0;
	}

	private bool IsEventStartTimePassed()
	{
		return false;
	}

	private bool CanStartEvent()
	{
		return false;
	}

	public double GetEventDaysPassed()
	{
		return 0.0;
	}

	public long GetEventTime()
	{
		return 0L;
	}

	public void UserZeroDayLoggedIn()
	{
	}

	public void EventAcknowledged()
	{
	}

	public void CheckNewEvent()
	{
	}

	private void NewEventStarted()
	{
	}

	private void StartEventTimer()
	{
	}

	private void StopEventTimer()
	{
	}

	[IteratorStateMachine(typeof(_003CEventTimerCoroutine_003Ed__50))]
	private IEnumerator EventTimerCoroutine()
	{
		return null;
	}

	private void CalculateEventRemainingTime()
	{
	}

	private bool CalculateDailyRemainingTime()
	{
		return false;
	}

	private void UpdateDailyEventEndTime()
	{
	}

	public void UpdateMissionProgress(MissionType missionType, int progressMade = 1)
	{
	}

	public void UpdateProgress(int matches)
	{
	}

	private void DailyEventEnded()
	{
	}

	private void UpdateEventTimeData()
	{
	}

	private void EventEnd()
	{
	}

	private void ResetAllEventData()
	{
	}

	private void UpdateAllOffersPurchased()
	{
	}
}
