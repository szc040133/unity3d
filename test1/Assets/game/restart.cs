using UnityEngine;
using System.Collections;

public class restart : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        if (GUI.Button(new Rect(80, 100, 60, 30), "退出"))
        {
            Application.Quit();
        }
        if (GUI.Button(new Rect(280, 100, 60, 30), "重新开始"))
        {
            Application.LoadLevel("Course2");
        }
        if (GUI.Button(new Rect(10, 160, 100, 50), "play"))
        {
            audio.Play();
        }
        if (GUI.Button(new Rect(10, 220, 100, 50), "pasue"))
        {
            audio.Pause();
        }
        if (GUI.Button(new Rect(10, 280, 100, 50), "stop"))
        {
            audio.Stop();
        }


    }
}
