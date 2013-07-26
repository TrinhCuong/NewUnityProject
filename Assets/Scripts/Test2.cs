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
		string url = "https://github.com/TrinhCuong/NewUnityProject/blob/master/Assets/Scenes.unity3d";
		WWW www = new WWW(url);
		yield return www;
		if(www.isDone)
		{
			Debug.Log("OK");
			Debug.Log(www.error);
		}
		else
		{
			Debug.Log("No Ok");
		}
		
	}
}
