using UnityEngine;
using System.Collections;

public class movie1 : MonoBehaviour {

	// Use this for initialization
    public float moveSpeed = 10.0F;
    public Transform newObject;
    public int count;
    public int destoeyNum;
	void Start () {
       
	}
	
	// Update is called once per frame
	void Update () {
        //移动
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        transform.Translate(x, 0, y);
        //单机左键或者按下CTRL键生成子弹
        if (Input.GetButtonDown("Fire1"))
        {
           Transform clone;
           clone = Instantiate(newObject, transform.position, transform.rotation)as Transform;
           Vector3 fed = transform.TransformDirection(Vector3.forward);
           clone.rigidbody.AddForce(fed * 4000);
           count++;
            GUIText t=  GameObject.Find("nunText").GetComponent("GUIText") as GUIText;
            t.text = "射弹数："+count+"消灭数："+destoeyNum;
        }
        //旋转功能
        if(Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(0, -25 * Time.deltaTime, 0, Space.Self);
        }
        if(Input.GetKey(KeyCode.E))
        {
            transform.Rotate(0, 25 * Time.deltaTime, 0, Space.Self);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            transform.Rotate(-25 * Time.deltaTime, 0, 0, Space.Self);
        }
        if (Input.GetKey(KeyCode.C))
        {
            transform.Rotate(25 * Time.deltaTime, 0, 0, Space.Self);
        }
        if(Input.GetKey(KeyCode.H))
        {
            transform.Translate(0, 5 * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.N))
        {
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
    }

}
