using UnityEngine;
using System.Collections;

public class CreateObject : MonoBehaviour {

    public Transform Cube;
    public Transform Player;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        if (Input.GetButtonUp("Fire1"))
       {
         if(Cube)
         {
            Create(Cube);
         }
       }
        if (Input.GetButtonUp("Fire2"))
        {
            if (Player)
            {
                Create(Player);
            }
        }
	}
    void Create(Transform obj)
    {
        Vector3 pos = GetPosition();
        Instantiate(obj,pos,obj.rotation);
        Debug.Log("CreateObject"+obj.name+"at"+pos);
    }
    Vector3 GetPosition()
    {
        float x = Random.Range(-7, 7);
        float z = Random.Range(-4, 4);
        Vector3 tempVector3 = new Vector3(x,1,z);
        return tempVector3;
    }
}
