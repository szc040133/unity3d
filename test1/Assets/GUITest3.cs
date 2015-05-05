using UnityEngine;
using System.Collections;

public class GUITest3 : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUI.Label(new Rect(0, 0, 100, 50), "0,0");
        GUI.Label(new Rect(0,Screen.height-50,100,50),"Screen.height");
        GUI.Label(new Rect(Screen.width - 100, 0, 100, 50), "Screen.width");
        GUI.Label(new Rect(Screen.width - 100, Screen.height - 50, 100, 50), "Screen.width,Screen.height");
    }

}
