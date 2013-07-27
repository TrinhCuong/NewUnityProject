using UnityEngine;
using UnityEditor;
using System.Collections;

public class Test : MonoBehaviour 
{
	
	[MenuItem("Assets/Build AssetBundle From Selection - No dependency tracking")]
	static void ExportResourceNoTrack () 
	{
		// Bring up save panel
		string path = EditorUtility.SaveFilePanel ("Save Resource", "", "New Resource", "unity3d");
		if (path.Length != 0) 
		{
			// Build the resource file from the active selection.
			BuildPipeline.BuildAssetBundle(Selection.activeObject, Selection.objects, path);
		}
	}
	
	[MenuItem("Assets/Build Scenes")]
	static void ExportScenes () 
	{
		string[] levels = new string[]{"Assets/Scene1.unity"};
		BuildPipeline.BuildStreamedSceneAssetBundle(levels,"Assets/AssetBundle/Scenes.unity3d",BuildTarget.StandaloneWindows);
	}
}
