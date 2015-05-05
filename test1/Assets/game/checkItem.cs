using UnityEngine;
using System.Collections;

public class checkItem : MonoBehaviour {

	// Use this for initialization
    private int xm;
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
       Vector3 position = gameObject.transform.position;
       if(position.y<0)
       {
            movie1 move = GameObject.Find("Main Camera").GetComponent<movie1>();
            xm = move.destoeyNum++;
           if(xm>20)
           {
               GUIText t1 = GameObject.Find("nunText").GetComponent("GUIText") as GUIText;
               t1.text = "恭喜你过关！";
               move.enabled = false;
               GameObject.Find("dimian").GetComponent<restart>().enabled = true;

           }
           Destroy(gameObject);
       }

       
	}
    
}
