using UnityEngine;
using System.Collections;

public class Test2 : MonoBehaviour {

	// Use this for initialization
	void Start () 
	{
		StartCoroutine(LoadScenes());
	}
	
	// Update is called once per frame
	IEnumerator LoadScenes () 
	{
		string url = "https://github.com/TrinhCuong/NewUnityProject/blob/r2_version/Assets/AssetBundle/TestBundle.unity3d?raw=true";
		WWW www = new WWW(url);
		yield return www;
		if(www.isDone && string.IsNullOrEmpty(www.error))
		{
			AssetBundle assset = www.assetBundle;
			GameObject obejcts = assset.Load("Objects") as GameObject;
			Instantiate(obejcts);
		}
		else
		{
			Debug.Log("No Ok");
		}
	}
}
