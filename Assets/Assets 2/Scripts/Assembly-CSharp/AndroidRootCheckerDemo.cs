using UnityEngine;
using UnityEngine.UI;

public class AndroidRootCheckerDemo : MonoBehaviour
{
	public Text Packages;

	public string PackagesFormat;

	public Text Files;

	public string FilesFormat;

	public Text Binaries;

	public string BinariesFormat;

	public Text DangerousProps;

	public string DangerousPropsFormat;

	public Text ReadWritePaths;

	public string ReadWritePathsFormat;

	public Text TestKeys;

	public string TestKeysFormat;

	public Text CommandsExists;

	public string CommandsExistsFormat;

	public Text Result;

	public string ResultFormat;

	private const string IsNotRooted = "not ";

	private const string Positive = "Yes";

	private const string Negative = "No";

	private void Awake()
	{
	}

	private void Update()
	{
	}
}
