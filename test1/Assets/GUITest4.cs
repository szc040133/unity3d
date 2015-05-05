using UnityEngine;
using System.Collections;

public class GUITest4 : MonoBehaviour {

	// Use this for initialization
    private string inputText = "Please input Something";
    private string showText = "";
    public Texture2D showPic;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
    void OnGUI()
    {
        GUI.Box(new Rect(20, 10, Screen.width - 40, 30), "");
        GUI.Label(new Rect(Screen.width / 2 - 50, 15, 100, 30), "chatRoom");
        GUI.Box(new Rect(20, 50, Screen.width / 2 - 20, Screen.height - 110), "");
        GUI.Label(new Rect(30, 60, Screen.width / 2 - 40, Screen.height - 150), showText);
        if(GUI.Button(new Rect(Screen.width/2-80,Screen.height-110,60,30),"clear"))
        {
            showText = "";
        }
        if(showPic)
        {

        }
    }


}
