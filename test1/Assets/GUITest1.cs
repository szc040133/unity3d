using UnityEngine;
using System.Collections;

public class GUITest1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUILayout.TextArea("hello world");
        GUILayout.Button("test1");
        GUILayout.Box("test2");
        GUILayout.Label("test3");
        GUILayout.TextField("hello");
        
    }
}
