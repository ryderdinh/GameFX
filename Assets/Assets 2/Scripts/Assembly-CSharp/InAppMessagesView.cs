using MS.Casual.IAP;
using MS.Store;
using MSKit.Database;
using UnityEngine;
using UnityEngine.Purchasing;

public class InAppMessagesView : MonoBehaviour
{
	[SerializeField]
	private ViewConfig _viewConfig;

	private ViewAnimationController _viewAnimController;

	private static InAppMessagesView _instance;

	private bool _isMessageDialogActive;

	private DatabaseBoolState _restoreDialogState;

	public InAppMessagesViewRefs m_Refs;

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnPurchaseSuccessfull(TransactionRecord product, RestoreStatus restoreStatus, IAPRecordStatus status)
	{
	}

	private void OnPurchaseFailed(TransactionRecord product, PurchaseFailureReason reason)
	{
	}

	private void Awake()
	{
	}

	private void SetWaitingView(bool status)
	{
	}

	private void ShowMessageDialogue(InAppMessage message)
	{
	}

	private void OkButtonClicked()
	{
	}

	private void OnEscapeKeyPressed()
	{
	}

	private void Display()
	{
	}

	private void Hide()
	{
	}

	private void AnimateProcessingBar()
	{
	}

	private void KillProcessingBarTween()
	{
	}

	private void PlayButtonImpact()
	{
	}
}
