using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InAppMessagesViewRefs : MonoBehaviour
{
	public Transform _processingBar;

	public Image Overlay;

	public RectTransform Container;

	public GameObject m_UIObject;

	public GameObject m_Dialogue;

	public TextMeshProUGUI m_HeaderText;

	public TextMeshProUGUI m_HeaderTextTop;

	public TextMeshProUGUI m_DescriptionText;

	public Button m_OkButton;

	public Button m_CloseButton;

	public GameObject m_ProcessiongObject;

	public ViewConfig m_ViewConfigs;

	public TextMeshProUGUI m_OkButtonText;

	public ButtonPressed PurchaseButtonPressedController;

	public GameObject SuccessGroup;

	public GameObject FailGroup;
}
