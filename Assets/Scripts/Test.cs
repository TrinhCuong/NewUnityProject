using UnityEngine;
using System.Collections;

public class Test : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		StartCoroutine(download());
		
	}
	
	IEnumerator download()
	{
		WWW w = new WWW("https://github.com/TrinhCuong/NewUnityProject/blob/master/Assets/Textures/Koala.jpg");
		yield return w;
		if(w.isDone)
			renderer.material.mainTexture = w.texture;
	}
}
