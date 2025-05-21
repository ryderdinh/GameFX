using System;
using UnityEngine;

[Serializable]
public abstract class ResourcesAsset<T> where T : UnityEngine.Object
{
	private delegate void AssetLoadingEvent(T asset);

	[SerializeField]
	private string fileName;

	[SerializeField]
	private string fileGuid;

	[SerializeField]
	private string resourceFilePath;

	[SerializeField]
	private string filePath;

	private AssetLoadingEvent OnAssetLoadedCallback;

	public string FileName
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string FileGuid
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string FullFilePath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string ResourceFilePath
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public T LoadedFile { get; set; }

	public bool IsLoadingFile { get; private set; }

	~ResourcesAsset()
	{
	}

	public ResourcesAsset()
	{
	}

	public virtual void LoadAsset(Action<T> loadCallback)
	{
	}

	public virtual void LoadAsset(string resourcesPath, Action<T> loadCallback)
	{
	}

	public int SortOrder()
	{
		return 0;
	}
}
