using UnityEngine;
using System.Collections;

public class Change : MonoBehaviour
{
    public string[] objNames = new string[] { "Player", "Cube" };
    public Transform lightObj;
    private int i = 0;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 if(Input.GetButtonDown("Jump"))
     {
         if (i < objNames.Length - 1)
         {
             i++;
         }
         else
         {
             i = 0;
         }
         string tempName = objNames[i];
        // FindAndChange(tempName);
     }
    }
        void FindAndChange(string id){
        {
            if(id!="")
            {
                GameObject tempObj = GameObject.Find(id);
                if(tempObj!=null)
                {
                    if(lightObj)
                    {
                                
                         Follow follow = lightObj.GetComponent<Follow>();
                        if (follow)
                        {
                            follow.target = tempObj.transform;
                        }
                    }
                }
            }
        }
	}
}
