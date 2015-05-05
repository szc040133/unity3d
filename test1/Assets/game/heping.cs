using UnityEngine;
using System.Collections;

public class heping : MonoBehaviour {

	// Use this for initialization
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
       
	}
    void OncollisonEnter()
    {
       GameObject.Find("nunText").GetComponent<GUIText>().text = "如果失去和平，世界将会怎样！";
       GameObject.Find("pxg").GetComponent<Light>().enabled = false;
       GameObject.Find("Point light").GetComponent<Light>().enabled = false;
       Destroy(gameObject);
    }
}
