using UnityEngine;
using System.Collections;

public class Rota : MonoBehaviour {

    public float rotaSpeed = 20;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime * rotaSpeed, Space.World);
	}
}
