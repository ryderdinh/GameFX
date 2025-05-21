using Core.Server;
using MSKit.UIView;
using TMPro;
using UnityEngine.UI;

public class SettingsPanelViewRefs : BaseUIViewRefs
{
	public SoundMixerController SoundMixerController;

	public Slider SliderMusic;

	public Slider SliderSfx;

	public SwitchToggle HapticsToggle;

	public Button PrivacyButton;

	public TextMeshProUGUI VersionText;

	public TextMeshProUGUI NakamaIdText;

	public NakamaServer NakamaServer;

	public Button CopyButton;

	public HelpShiftView HelpShiftView;
}
