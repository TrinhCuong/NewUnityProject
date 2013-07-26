using UnityEngine;
using UnityEditor;
using System.Collections;

public class Test : MonoBehaviour 
{
	// Use this for initialization
	void Start () 
	{
		
		
	}
	
	[MenuItem("Assets/Build Scenes To Asset Bundles")]
	static void BuildScene()
	{
		string[] levels = new string[]{"Assets/Scene1.unity"};
		if(string.IsNullOrEmpty(BuildPipeline.BuildStreamedSceneAssetBundle(levels,"Assets/Scenes.unity3d",BuildTarget.StandaloneWindows)))
			Debug.Log("ok");
		else
			Debug.Log("no ok");
	}
}
