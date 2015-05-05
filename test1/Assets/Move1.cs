using UnityEngine;
using System.Collections;

public class Move1 : MonoBehaviour
{
    public float moveSpeed = 10.0F;
    public float rotationSpeed = 100.0f;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    
    void Update()
    {
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
        float y = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
        
        transform.Translate(x, 0, y);
        //float translation = Input.GetAxis("Vertical") * moveSpeed;
        //float rotation = Input.GetAxis("Horizontal") * rotationSpeed;
        //translation *= Time.deltaTime;
        //rotation *= Time.deltaTime;
        //transform.Translate(0, 0, translation);
        //transform.Rotate(0, rotation, 0);
       

    }
    
        

   
    

}


