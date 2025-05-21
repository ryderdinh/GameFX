using UnityEngine;
using UnityEngine.UI;

public class JailbreakCheckerDemo : MonoBehaviour
{
	public Text PID;

	public string PIDFormat;

	public Text Schemes;

	public string SchemesFormat;

	public Text Files;

	public string FilesFormat;

	public Text Symlinks;

	public string SymlinksFormat;

	public Text Dyld;

	public string DyldFormat;

	public Text Result;

	public string ResultFormat;

	private const string IsNotJailbroken = "not ";

	private const string Positive = "Yes";

	private const string Negative = "No";

	private void Awake()
	{
	}
}
