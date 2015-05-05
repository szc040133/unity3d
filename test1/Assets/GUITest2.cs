using UnityEngine;
using System.Collections;

public class GUITest2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUI.Button(new Rect(10, 10, 300, 50), "test1");
        GUI.Box(new Rect(10, 60, 100, 80), "test2");
        GUI.Label(new Rect(10, 140, 200, 70), "test3");
        GUI.TextField(new Rect(10, 210, 250, 40), "hello");
        GUI.TextArea(new Rect(10, 250, 400, 60), "hello world");

    }
}
